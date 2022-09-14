using Application.Utilites.Helper;

namespace Api.Middlewares
{
    public class JwtTokenMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtTokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, ITokenHelper tokenHelper)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
            {
                context.Items["AppAccount"] = tokenHelper.GetAppAccountByJwtToken(token);
            }

            await _next(context);
        }
    }
}
