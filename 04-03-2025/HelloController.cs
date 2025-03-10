using BusinessLayer.Interface;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;
namespace HelloGreetingApplication.Controllers
{
/// &lt;summary&gt;
/// Class providing API for HelloGreeting
/// &lt;/summary&gt;
[ApiController]
[Route(&quot;[controller]&quot;)]
public class HelloGreetingController : ControllerBase
{
private static Dictionary&lt;string, string&gt; greetings = new
Dictionary&lt;string, string&gt;();
private readonly IGreetingBL _greetingBL;
public HelloGreetingController(IGreetingBL greetingBL)
{
_greetingBL = greetingBL;
}
/// &lt;summary&gt;
/// Get method to get the greeting message
/// &lt;/summary&gt;
/// &lt;returns&gt; &quot;Hello World&quot; &lt;/returns&gt;
[HttpGet]
public IActionResult GetMethod()
{
ResponseModel&lt;string&gt; responseModel = new
ResponseModel&lt;string&gt;();
responseModel.Success = true;
responseModel.Message = &quot;Hello to Greeting App Api
endpoint.&quot;;
responseModel.Data = &quot;Hello World&quot;;
return Ok(responseModel);
}
/// &lt;summary&gt;
/// Post method to get the greeting message

/// &lt;/summary&gt;
/// &lt;param name=&quot;requestModel&quot;&gt;&lt;/param&gt;
/// &lt;returns&gt; response model&lt;/returns&gt;
[HttpPost]
public IActionResult Post(RequestModel requestModel) {
if (requestModel == null ||
string.IsNullOrWhiteSpace(requestModel.Key) ||
string.IsNullOrWhiteSpace(requestModel.Value))
{
return BadRequest(new ResponseModel&lt;string&gt;
{
Success = false,
Message = &quot;Key and Value are required.&quot;,
Data = null
});
}
if (greetings.ContainsKey(requestModel.Key))
{
return Conflict(new ResponseModel&lt;string&gt;
{
Success = false,
Message = &quot;Key already exists. Use a different
key.&quot;,
Data = null
});
}
greetings[requestModel.Key] = requestModel.Value;
return Ok(new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Greeting added successfully.&quot;,
Data = $&quot;Key: {requestModel.Key}, Value:
{requestModel.Value}&quot;
});
}
/// &lt;summary&gt;
///
/// &lt;/summary&gt;
/// &lt;param name=&quot;key&quot;&gt;&lt;/param&gt;
/// &lt;param name=&quot;newValue&quot;&gt;&lt;/param&gt;

/// &lt;returns&gt;Updated greeting message&lt;/returns&gt;
[HttpPut(&quot;{key}&quot;)]
public IActionResult Put(string key, string newValue)
{
if (!greetings.ContainsKey(key))
{
return NotFound(new ResponseModel&lt;string&gt;
{
Success = false,
Message = &quot;Greeting not found.&quot;,
Data = null
});
}
greetings[key] = newValue;
return Ok(new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Greeting updated successfully.&quot;,
Data = $&quot;Key: {key}, Value: {newValue}&quot;
});
}
/// &lt;summary&gt;
/// Delete method to remove a greeting message
/// &lt;/summary&gt;
/// &lt;param name=&quot;key&quot;&gt;&lt;/param&gt;
/// &lt;returns&gt;Deleted greeting message&lt;/returns&gt;
[HttpDelete]
public IActionResult Delete(string key)
{
if (!greetings.ContainsKey(key))
{
return NotFound(new ResponseModel&lt;string&gt;
{
Success = false,
Message = &quot;Greeting not found.&quot;,
Data = null
});
}
string removedGreeting = greetings[key];

greetings.Remove(key);
return Ok(new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Greeting deleted successfully.&quot;,
Data = $&quot;Key: {key}, Value: {removedGreeting}&quot;
});
}
[HttpPatch(&quot;{key}&quot;)]
public IActionResult Patch(string key, string
partialUpdate)
{
if (!greetings.ContainsKey(key))
{
return NotFound(new ResponseModel&lt;string&gt;
{
Success = false,
Message = &quot;Greeting not found.&quot;,
Data = null
});
}
greetings[key] += &quot; &quot; + partialUpdate;
return Ok(new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Greeting modified successfully.&quot;,
Data = $&quot;Key: {key}, Value: {greetings[key]}&quot;
});
}
//[HttpGet(&quot;Greet&quot;)]
//public IActionResult GetGreeting()
//{
// var greetingMessage =
_greetingBL.GetGreetingMessage();
// var response = new ResponseModel&lt;string&gt;
// {
// Success = true,
// Message = &quot;Greeting retrieved successfully.&quot;,
// Data = greetingMessage
// };

// return Ok(response);
//}
/// &lt;summary&gt;
/// Get a greeting message based on user name.
/// &lt;/summary&gt;
[HttpGet(&quot;personalizedgreet&quot;)]
public IActionResult GetGreeting([FromQuery] string?
firstName=null, [FromQuery] string lastName)
{
var greetingMessage =
_greetingBL.GetGreetingMessage(firstName, lastName);
var response = new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Greeting retrieved successfully.&quot;,
Data = greetingMessage
};
return Ok(response);
}
/// &lt;summary&gt;
/// Post method to get a greeting using a request body.
/// &lt;/summary&gt;
[HttpPost(&quot;personalizedgreet&quot;)]
public IActionResult PostGreeting([FromBody]
GreetingRequestModel requestModel)
{
var greetingMessage =
_greetingBL.GetPersonalizedGreeting(requestModel);
var response = new ResponseModel&lt;string&gt;
{
Success = true,
Message = &quot;Personalized greeting created
successfully.&quot;,
Data = greetingMessage
};
return Ok(response);
}

}
