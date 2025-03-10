using ModelLayer.DTO;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service
{
public class RegisterHelloRL: IRegisterHelloRL
{
//private string databaseusername = &quot;root&quot;;
//private string databasepassword = &quot;root&quot;;

//public string _username { get; set; } = &quot;root&quot;;
//public string _password { get; set; } = &quot;root&quot;;
private static readonly Logger _logger =
LogManager.GetCurrentClassLogger();
private readonly HelloAppContext _context;
public RegisterHelloRL(HelloAppContext context)
{
_context = context;
}

public string GetHello(string name)
{
_logger.Info(&quot;GetHello method called with
name: {0}&quot;, name);
return name + &quot;This is repository layer.&quot;;
}
public UserEntity GetUsernamePassword(LoginDTO
loginDTO)
{
//loginDTO.username = _username;
//loginDTO.password = _password;
//return loginDTO;
_logger.Info(&quot;Fetching user from database for
email: {0}&quot;, loginDTO.email);
return _context.Users.FirstOrDefault(u =&gt;
u.Email == loginDTO.email);
}
public UserEntity registration(RegisterDTO
registerDTO)

{
_logger.Info(&quot;Attempting to register new
user: {0}&quot;, registerDTO.Email);
var existingUser =
_context.Users.FirstOrDefault(e =&gt; e.Email ==
registerDTO.Email);
if (existingUser != null)
{
_logger.Warn(&quot;User already exists with
email: {0}&quot;, registerDTO.Email);
return null; // User already exists
}
var newUser = new UserEntity
{
FirstName = registerDTO.FirstName,
LastName = registerDTO.LastName,
Email = registerDTO.Email,
Password = registerDTO.Password
};
_context.Users.Add(newUser);
_context.SaveChanges();
_logger.Info(&quot;User registered successfully:
{0}&quot;, registerDTO.Email);
return newUser;
}
}
