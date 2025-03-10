using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client;

using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;
public class RabbitMQConsumer
{
private readonly string _hostname;
private readonly int _port;
private readonly string _username;
private readonly string _password;
private readonly string _queueName;
private readonly ILogger&lt;RabbitMQConsumer&gt; _logger;
public RabbitMQConsumer(IConfiguration configuration,
ILogger&lt;RabbitMQConsumer&gt; logger)
{
_hostname = configuration[&quot;RabbitMQ:HostName&quot;];
_port =
int.Parse(configuration[&quot;RabbitMQ:Port&quot;]);
_username = configuration[&quot;RabbitMQ:UserName&quot;];
_password = configuration[&quot;RabbitMQ:Password&quot;];
_queueName = configuration[&quot;RabbitMQ:QueueName&quot;];
_logger = logger;
}
public void ConsumeMessages()
{
try
{
var factory = new ConnectionFactory()
{
HostName = _hostname,
Port = _port,
UserName = _username,
Password = _password
};

var connection = factory.CreateConnection();
var channel = connection.CreateModel();
channel.QueueDeclare(queue: _queueName,
durable: false, exclusive: false, autoDelete: false,
arguments: null);
var consumer = new
EventingBasicConsumer(channel);
consumer.Received += (model, eventArgs) =&gt;
{
var body = eventArgs.Body.ToArray();
var message =
Encoding.UTF8.GetString(body);
_logger.LogInformation($&quot;Received
message: {message}&quot;);
};
channel.BasicConsume(queue: _queueName,
autoAck: true, consumer: consumer);
_logger.LogInformation(&quot;RabbitMQ Consumer
started. Listening for messages...&quot;);
Thread.Sleep(Timeout.Infinite); // Keep
listening
}
catch (Exception ex)
{
_logger.LogError($&quot;Error in RabbitMQ
Consumer: {ex.Message}&quot;);
}
}
}
UserController with rabbitMQ implemented→

using System.Security.Claims;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Helper;
namespace UserRegistration.Controllers
{
[ApiController]
[Route(&quot;api/[controller]&quot;)]
public class UserRegistrationController :
ControllerBase
{
private readonly IUserRegistrationBL
_userRegistrationBL;
private readonly RabbitMQProducer
_rabbitMQProducer; // Inject RabbitMQProducer
private static readonly Logger logger =
LogManager.GetCurrentClassLogger();
public
UserRegistrationController(IUserRegistrationBL
userRegistrationBL, RabbitMQProducer rabbitMQProducer)
{
_userRegistrationBL = userRegistrationBL;
_rabbitMQProducer = rabbitMQProducer;
}
[HttpPost(&quot;login&quot;)]
public IActionResult LoginUser(LoginDTO loginDTO)
{
var (token, isCached) =
_userRegistrationBL.loginBL(loginDTO);

if (token == null)
{
return Unauthorized(new { Success =
false, Message = &quot;Invalid email or password&quot; });
}
var response = new
ResponseModel&lt;LoginResponse&gt;
{
Success = true,
Message = &quot;Login Successful&quot;,
Data = new LoginResponse
{
Email = loginDTO.Email,
Token = token,
Cached = isCached
}
};
// Publish login event to RabbitMQ
_rabbitMQProducer.PublishMessage(&quot;User logged
in: &quot; + loginDTO.Email);
return Ok(response);
}
[HttpPost(&quot;Register&quot;)]
public IActionResult RegisterUser(UserDTO user)
{
try
{
var result =
_userRegistrationBL.RegisterUser(user);
if (result)
{

logger.Info(&quot;User registered
successfully.&quot;);
// Publish registration event to
RabbitMQ
_rabbitMQProducer.PublishMessage(&quot;New
user registered: &quot; + user.Email);
return Ok(new
{
Success = true,
Message = &quot;User registered
successfully. Redis cache cleared for this email.&quot;
});
}
else
{
return BadRequest(new { Success =
false, Message = &quot;User registration failed&quot; });
}
}
catch (Exception ex)
{
logger.Error(ex, &quot;Error while registering
user.&quot;);
return StatusCode(500, new { Success =
false, Message = &quot;Internal Server Error&quot; });
}
}
[Authorize]
[HttpGet(&quot;profile&quot;)]
public IActionResult GetUserProfile()
{
var identity = HttpContext.User.Identity as
ClaimsIdentity;

if (identity == null)
{
return Unauthorized(new { Success =
false, Message = &quot;Unauthorized access&quot; });
}
var claims = identity.Claims;
int id = int.Parse(claims.FirstOrDefault(c =&gt;
c.Type == &quot;ID&quot;)?.Value);
string firstName = claims.FirstOrDefault(c =&gt;
c.Type == &quot;FirstName&quot;)?.Value;
string lastName = claims.FirstOrDefault(c =&gt;
c.Type == &quot;LastName&quot;)?.Value;
string email = claims.FirstOrDefault(c =&gt;
c.Type == ClaimTypes.Email)?.Value;
var profileData = new
{
ID = id,
FirstName = firstName,
LastName = lastName,
Email = email
};
// Publish profile retrieval event to
RabbitMQ
_rabbitMQProducer.PublishMessage(&quot;User
profile accessed: &quot; + email);
return Ok(new
{
Success = true,
Message = &quot;User details retrieved&quot;,
Data = profileData
});
}

[HttpPost(&quot;forgot-password&quot;)]
public IActionResult ForgotPassword([FromBody]
ForgotPasswordDTO forgotPasswordDTO)
{
try
{
var result =
_userRegistrationBL.ForgotPasswordBL(forgotPasswordDTO.Em
ail);
if (result)
{
// Publish forgot password event to
RabbitMQ
_rabbitMQProducer.PublishMessage(&quot;Forgot password
request: &quot; + forgotPasswordDTO.Email);
return Ok(new
{
Success = true,
Message = &quot;Password reset
instructions sent to your email&quot;
});
}
else
{
return BadRequest(new
{
Success = false,
Message = &quot;Failed to process
password reset request&quot;
});
}
}
catch (Exception ex)
{
logger.Error(ex, &quot;Error in controller

while processing forgot password request&quot;);
return StatusCode(500, new { Success =
false, Message = &quot;Internal Server Error&quot; });
}
}
[HttpPost(&quot;reset-password&quot;)]
public IActionResult ResetPassword([FromQuery]
string token, [FromBody] ResetPasswordDTO
resetPasswordDTO)
{
try
{
logger.Info($&quot;Reset password request
received. Token length: {token?.Length ?? 0}&quot;);
if (string.IsNullOrEmpty(token))
{
logger.Warn(&quot;Token is null or empty
in reset password request&quot;);
return BadRequest(new { Success =
false, Message = &quot;Token is required&quot; });
}
if (resetPasswordDTO == null)
{
logger.Warn(&quot;Reset password DTO is
null&quot;);
return BadRequest(new { Success =
false, Message = &quot;Password data is required&quot; });
}
logger.Info($&quot;New password length:
{resetPasswordDTO.NewPassword?.Length ?? 0}, Confirm
password length:
{resetPasswordDTO.ConfirmPassword?.Length ?? 0}&quot;);

var result =
_userRegistrationBL.ResetPasswordBL(
token,
resetPasswordDTO.NewPassword,
resetPasswordDTO.ConfirmPassword
);
if (result)
{
// Publish reset password event to
RabbitMQ
_rabbitMQProducer.PublishMessage(&quot;Password reset
successful for token: &quot; + token);
return Ok(new
{
Success = true,
Message = &quot;Password reset
successful. Please login with your new password.&quot;
});
}
else
{
return BadRequest(new
{
Success = false,
Message = &quot;Failed to reset
password. The token may be invalid or expired, or
passwords don&#39;t match.&quot;
});
}
}
catch (Exception ex)
{
logger.Error(ex, &quot;Error in controller
while resetting password&quot;);
return StatusCode(500, new { Success =

false, Message = &quot;Internal Server Error&quot; });
}
}
}
