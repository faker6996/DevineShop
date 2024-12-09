using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MARShop.Application
{
    public static class DDependencies
    {
        public static IServiceCollection AddRequestHandlers(
           this IServiceCollection services)
        {
            return services
                .AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
        }
    }
}
