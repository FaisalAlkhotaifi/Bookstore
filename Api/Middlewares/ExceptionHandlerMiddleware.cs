using Application.Utilites.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace Api.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await ConvertException(context, ex);
            }
        }

        #region Private

        private Task ConvertException(HttpContext context, Exception exception)
        {
            int httpStatusCode = (int)HttpStatusCode.InternalServerError;

            switch (exception)
            {
                case ValidationException ve:
                case NotFoundException ne: 
                case AppException ae:
                    httpStatusCode = (int)HttpStatusCode.BadRequest;

                    break;
                default:
                    httpStatusCode = (int)HttpStatusCode.InternalServerError;

                    break;
            }

            context.Response.StatusCode = httpStatusCode;
            context.Response.ContentType = "application/json";
            return context.Response.WriteAsync(JsonConvert.SerializeObject(exception.Message));
        }

        #endregion
    }
}
