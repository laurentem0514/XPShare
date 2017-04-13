using Microsoft.Extensions.DependencyInjection;
using XPShare.Domain.Stubs.Users;
using XPShare.Domain.Users;

namespace XPShare.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();

        }
    }
}
