using HotChocolate.Execution;

namespace MiddlewareTest.Middleware
{
    public class MetricsMiddleware
    {
        private readonly HotChocolate.Execution.RequestDelegate _next;

        public MetricsMiddleware(HotChocolate.Execution.RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(IRequestContext context)
        {
            // Do something
            await _next(context);
            // Do something
        }
    }
}
