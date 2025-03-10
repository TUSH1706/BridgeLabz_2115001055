using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using NLog.Web;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
var builder = WebApplication.CreateBuilder(args);
var connectionString =
builder.Configuration.GetConnectionString(&quot;EmployeeDB&quot;);
// Add services to the container.
builder.Services.AddDbContext&lt;EmployeeContext&gt;(options =&gt;

options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddScoped&lt;IEmployeeBL, EmployeeBL&gt;();
builder.Services.AddScoped&lt;IAddEmployee,
EmployeeService&gt;();
//Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configure NLog
builder.Logging.ClearProviders();
builder.Host.UseNLog();
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();