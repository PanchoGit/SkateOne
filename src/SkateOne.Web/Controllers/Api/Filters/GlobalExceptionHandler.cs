using System.Net;
using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using Common.Logger;
using Common.Logger.Interface;
using SkateOne.Web.Models;

namespace SkateOne.Web.Controllers.Api.Filters
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        private readonly ILoggerWrapper logger;

        public GlobalExceptionHandler()
        {
            logger = new LoggerWrapper(typeof(GlobalExceptionHandler));
        }

        public override void Handle(ExceptionHandlerContext context)
        {
            var responseObject =
                new
                {
                    Data =
                        new
                        {
                            Success = false,
                            Error = new { context.Exception.Message, context.Exception.StackTrace }
                        }
                };

            context.Result = new UnhandledExceptionActionResult(context.Request.CreateResponse(HttpStatusCode.InternalServerError, responseObject));

            logger.LogError(context.Exception.Message, context.Exception);
#if DEBUG
            throw context.Exception;
#endif
        }
    }
}