using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;
using NLog;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service

{
public class EmployeeService: IAddEmployee
{
private readonly EmployeeContext _context;
private static readonly Logger _logger =
LogManager.GetCurrentClassLogger();
public EmployeeService(EmployeeContext context)
{
_context = context;
}
public void AddEmployee(Employee employee)
{
// Implementation logic here
try
{
_logger.Info(&quot;Adding a new employee:
{Name}&quot;, employee.Name);
_context.Employees.Add(employee);
_context.SaveChanges();
_logger.Info(&quot;Employee added
successfully: {Name}&quot;, employee.Name);
}
catch (Exception ex)
{
_logger.Error(ex, &quot;An error occurred
while adding the employee: {Name}&quot;, employee.Name);
throw new Exception(&quot;An error occurred
while adding the employee.&quot;, ex);
}
}
}
}