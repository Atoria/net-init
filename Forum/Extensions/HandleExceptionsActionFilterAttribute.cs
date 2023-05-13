using System.Threading.Tasks;
using DataAccess;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Forum.Extensions
{
    public sealed class HandleExceptionsActionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly ForumContext _context;

        public HandleExceptionsActionFilterAttribute(ForumContext context)
        {
            _context = context;
        }

        public override async Task OnExceptionAsync(ExceptionContext context)
        {
            var exception = context.Exception;

            //Add logger for internal exceptions
            
           

            context.Result = new ObjectResult(OperationResult.InteralError) {StatusCode = 500};
        }
    }
}