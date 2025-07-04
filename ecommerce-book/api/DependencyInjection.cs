using application;
using infrastructure;

namespace api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIDI(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddApplicationDI()
                    .AddInfrastructureDI();
            return services;
        }
    }
}
