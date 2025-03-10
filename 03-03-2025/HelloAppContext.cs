using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace RepositoryLayer.Context
{
public class HelloAppContext:DbContext
{
public
HelloAppContext(DbContextOptions&lt;HelloAppContext&gt;
options) : base(options) { }
public virtual DbSet&lt;Entity.UserEntity&gt; Users {
get; set; }
}
