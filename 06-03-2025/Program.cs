using BusinessLayer.Interface;
using BusinessLayer.Service;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;
using RepositoryLayer.Service;
using StackExchange.Redis;
var builder = WebApplication.CreateBuilder(args);
var connectionString =
builder.Configuration.GetConnectionString(&quot;GreetingDB&quot;);
// Add services to the container.
builder.Services.AddDbContext&lt;GreetingDBContext&gt;(options
=&gt; options.UseSqlServer(connectionString));

builder.Services.AddControllers();
//Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped&lt;IGreetingBL,GreetingBL&gt;();
builder.Services.AddScoped&lt;IGreetingRL, GreetingRL&gt;();
//Add Redis
var redisConnectionString =
builder.Configuration.GetConnectionString(&quot;Redis&quot;);
builder.Services.AddSingleton&lt;IConnectionMultiplexer&gt;(Con
nectionMultiplexer.Connect(redisConnectionString));

var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();