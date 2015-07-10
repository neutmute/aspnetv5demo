using Common.Logging;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetv5.Middleware
{
    public static class LogMiddlwareExtensions
    {
        public static IApplicationBuilder UseNaiveLogOnErrorMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<NaiveLogOnErrorMiddleware>();
        }
    }

    /// <summary>
    /// Naive implementation - loggerFactory in combination with the aspnet errorhandler would be better with injectable logs
    /// </summary>
    public class NaiveLogOnErrorMiddleware
    {
        private readonly RequestDelegate _next;
        ILog Log = LogManager.GetLogger<NaiveLogOnErrorMiddleware>();

        public NaiveLogOnErrorMiddleware(RequestDelegate next)
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
                PathString originalPath = context.Request.Path;
                var message = string.Format("Failure at {0}", originalPath);
                Log.Error(message, ex);
                throw;
            }
        }
    }
}
