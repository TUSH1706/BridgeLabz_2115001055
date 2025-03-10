using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModelLayer.Model
{
public class ResponseModel&lt;T&gt;
{
public bool Success { get; set; } = false;
public string Message { get; set; } = &quot; &quot;;
public T Data { get; set; } = default(T);
}
