using BusinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Mvc;
using NLog;
namespace EmployeeManagement.Controllers
{
[ApiController]
[Route(&quot;[controller]&quot;)]
public class EmployeeManagementController :
ControllerBase
{
private readonly IEmployeeBL _employeeBusiness;
private static readonly Logger _logger =

LogManager.GetCurrentClassLogger();
public EmployeeManagementController(IEmployeeBL
employeeBusiness)
{
_employeeBusiness = employeeBusiness;
}
[HttpGet]
public string Get()
{
return &quot;Server running..&quot;;
}
[HttpPost]
public IActionResult AddEmployee([FromBody]
Employee employee)
{
try
{
_logger.Info(&quot;Received request to add
employee: {Name}&quot;, employee.Name);
_employeeBusiness.AddEmployee(employee);
_logger.Info(&quot;Employee added
successfully: {Name}&quot;, employee.Name);
return Ok(&quot;Employee added successfully&quot;);
}
catch (Exception ex)
{
_logger.Error(ex, &quot;Internal Server Error
while adding employee: {Name}&quot;, employee.Name);
return StatusCode(500, new { message =
&quot;Internal Server Error&quot;, error = ex.Message });
}
}

}

