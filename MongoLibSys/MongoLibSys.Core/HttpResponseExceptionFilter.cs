using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MongoLibSys.Core.Exceptions;

namespace MongoLibSys.Core
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order => -10;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception is HttpException httpException)
            {
                context.Result = new ObjectResult(httpException.Body) 
                {
                    StatusCode = httpException.Status
                };
                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) {}
    }
}
