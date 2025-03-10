using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using ModelLayer.Model;
using RepositoryLayer.Interface;
namespace BusinessLayer.Service
{
public class GreetingBL:IGreetingBL
{
private readonly IGreetingRL _greetingRL;
public GreetingBL(IGreetingRL greetingRL)
{
_greetingRL = greetingRL;
}

public string GetGreetingMessage(string firstName, string
lastName)
{
return GenerateGreeting(firstName, lastName);
}
public string GetPersonalizedGreeting(GreetingRequestModel
request)
{
return GenerateGreeting(request.FirstName,
request.LastName);
}

private string GenerateGreeting(string firstName, string
lastName)
{
if (!string.IsNullOrWhiteSpace(firstName) &amp;&amp;
!string.IsNullOrWhiteSpace(lastName))
{
return $&quot;Hello, {firstName} {lastName}!&quot;;
}
else if (!string.IsNullOrWhiteSpace(firstName))
{
return $&quot;Hello, {firstName}!&quot;;
}
else if (!string.IsNullOrWhiteSpace(lastName))
{
return $&quot;Hello, {lastName}!&quot;;
}
return _greetingRL.GetGreeting();
}

}
}