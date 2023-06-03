using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MARShop.Application
{
    public static class DDependencies
    {
        public static IServiceCollection AddRequestHandlers(
           this IServiceCollection services)
        {
            return services
                .AddMediatR(typeof(DDependencies).Assembly);
        }
    }
}
