using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer;
using NLog;
using RepositoryLayer.Interface;
namespace BusinessLayer.Service
{
public class EmployeeBL:IEmployeeBL
{
private readonly IAddEmployee
_employeeRepository;
private static readonly Logger _logger =
LogManager.GetCurrentClassLogger();
public EmployeeBL(IAddEmployee
employeeRepository)
{
_employeeRepository = employeeRepository;
}
public void AddEmployee(Employee employee)
{
try

{
_logger.Info(&quot;Processing employee
addition: {Name}&quot;, employee.Name);
_employeeRepository.AddEmployee(employee);
_logger.Info(&quot;Employee addition
successful: {Name}&quot;, employee.Name);
}
catch (Exception ex)
{
_logger.Error(ex, &quot;Business logic error:
Unable to add employee: {Name}&quot;, employee.Name);
throw new Exception(&quot;Business logic
error: Unable to add employee.&quot;, ex);
}
}
}
