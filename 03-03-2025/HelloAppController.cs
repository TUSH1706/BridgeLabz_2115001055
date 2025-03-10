using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Entity;
namespace HelloApp.Controllers
{
[ApiController]
[Route(&quot;[controller]&quot;)]
public class HelloAppController : ControllerBase
{
private static readonly Logger _logger =
LogManager.GetCurrentClassLogger();
private readonly IRegisterHelloBL

_registerHelloBL;
ResponseModel&lt;string&gt; response;

public HelloAppController(IRegisterHelloBL
registerHelloBL)
{
_registerHelloBL = registerHelloBL;
}

[HttpGet]
public string Get()
{
_logger.Info(&quot;Get() method called.&quot;);
return _registerHelloBL.registration(&quot;Value
from controller&quot;);
}
[HttpPost(&quot;login&quot;)]
public IActionResult PostData(LoginDTO loginDTO)
{

try
{
//response = new ResponseModel&lt;string&gt;();
_logger.Info(&quot;Login attempt for user:
{0}&quot;, loginDTO.email);
var user=
_registerHelloBL.LoginUser(loginDTO);
// if (user==null)
// {

// response.Success = false;
// response.Message = &quot;Invalid
username or password.&quot;;
// return Unauthorized(response);
// }
// response.Success = true;
// response.Message = &quot;Login
Successfull.&quot;;
// response.Data = &quot; &quot;;
// return Ok(response);

//}
//catch (Exception ex)
//{
// response.Success = false;
// response.Message = &quot;Login failed.&quot;;
// response.Data = ex.Message;
// return BadRequest();
//}
if (user == null)
{
_logger.Warn(&quot;Invalid login attempt
for user: {0}&quot;, loginDTO.email);
return Unauthorized(new { Success =
false, Message = &quot;Invalid username or password.&quot; });
}
_logger.Info(&quot;User {0} logged in
successfully.&quot;, loginDTO.email);
return Ok(new { Success = true, Message =
&quot;Login Successful.&quot; });

}
catch (Exception ex)
{
_logger.Error(ex, &quot;Login failed.&quot;);
return BadRequest(new { Success = false,
Message = &quot;Login failed.&quot;, Error = ex.Message });
}

}
[HttpPost(&quot;register&quot;)]
public IActionResult Register(RegisterDTO
registerDTO) {
//ResponseModel&lt;RegisterResponse&gt; response =
new ResponseModel&lt;RegisterResponse&gt;();
//var newUser =
_registerHelloBL.RegisterBL(registerDTO);
//if (newUser == null)
//{
// response.Success = false;
// response.Message = &quot;User with this
email already exists.&quot;;
// return Conflict(response);
//}

//var registerResponse = new RegisterResponse
//{
// FirstName = newUser.FirstName,
// LastName = newUser.LastName,
// Email = newUser.Email
//};

//response.Success = true;
//response.Message = &quot;User registered
successfully.&quot;;
//response.Data = registerResponse;
//return Created(&quot;user registered&quot;,
response);
_logger.Info(&quot;Register attempt for email:
{0}&quot;, registerDTO.Email);
var newUser =
_registerHelloBL.RegisterBL(registerDTO);
if (newUser == null)
{
_logger.Warn(&quot;Registration failed. Email
already exists: {0}&quot;, registerDTO.Email);
return Conflict(new { Success = false,
Message = &quot;User with this email already exists.&quot; });
}
_logger.Info(&quot;User registered successfully:
{0}&quot;, registerDTO.Email);
return Created(&quot;user registered&quot;, new {
Success = true, Message = &quot;User registered successfully.&quot;
});
}
}
}