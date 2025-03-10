using BusinessLayer.Service;
using BusinessLayer.Interface;
using ModelLayer.DTO;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var logger =
LogManager.Setup().LoadConfigurationFromFile(&quot;nlog.config
&quot;).GetCurrentClassLogger();

try
{
var builder = WebApplication.CreateBuilder(args);
var connectionString =
builder.Configuration.GetConnectionString(&quot;SqlConnection&quot;
);
// Configure NLog
builder.Logging.ClearProviders();
builder.Host.UseNLog();

// Add services to the container.
builder.Services.AddDbContext&lt;HelloAppContext&gt;(options =&gt;
options.UseSqlServer(connectionString));
builder.Services.AddControllers();
builder.Services.AddScoped&lt;IRegisterHelloBL,
RegisterHelloBL&gt;();
builder.Services.AddScoped&lt;IRegisterHelloRL,
RegisterHelloRL&gt;();
//Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
}
catch (Exception ex)
{
logger.Error(ex, &quot;Application failed to start.&quot;);
throw;
}
finally
{
LogManager.Shutdown();
}