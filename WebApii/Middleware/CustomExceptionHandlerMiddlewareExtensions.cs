using System.Runtime.CompilerServices;

namespace WebApii.Middleware
{
    public static class CustomExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder) 
        {
            return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
        }
    }
}
