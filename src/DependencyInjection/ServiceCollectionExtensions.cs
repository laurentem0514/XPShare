using Microsoft.Extensions.DependencyInjection;
using XPShare.Domain.Stubs.Users;
using XPShare.Domain.Users;
using XPShare.Domain.Experiences;
using XPShare.Domain.Stubs.Experiences;

namespace XPShare.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IExperienceRepository, ExperienceRepository>();
        }
    }
}
