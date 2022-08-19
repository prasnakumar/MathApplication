using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathApplication.Controllers.Filter
{
    public class CustomActionFIlterAttributes : Attribute ,IActionFilter
    {
        private readonly string _check;
       
        public CustomActionFIlterAttributes(string  check)
        {
           
            _check = check;
           

        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

            var paramChecks = context.HttpContext.Request.QueryString.Value;
            Console.WriteLine($"OnActionExecutedContext controller {_check} parameters sent with the request {paramChecks}");

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var paramChecks = context.HttpContext.Request.QueryString.Value;

            Console.WriteLine($"OnActionExecuting  controller {_check} parameters sent with the request { paramChecks}"   );
           
      
        }
    }
}
