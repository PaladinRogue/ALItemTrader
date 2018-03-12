using ALItemTrader.Setup.Middleware;
using Microsoft.AspNetCore.Builder;

namespace ALItemTrader.Setup
{
    public class MiddlewareRegistration
    {
        public static void RegisterTransactionPerRequest(IApplicationBuilder app)
        {
            app.UseMiddleware<TransactionPerRequestMiddleware>();
        }
    }
}

