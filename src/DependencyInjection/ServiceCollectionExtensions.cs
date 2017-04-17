using Microsoft.Extensions.DependencyInjection;
using XPShare.Domain.Stubs.Users;
using XPShare.Domain.Users;
using XPShare.Domain.Experiences;
using XPShare.Domain.Stubs.Experiences;
using XPShare.Domain.Projects;
using XPShare.Domain.Stubs.Projects;
using XPShare.Domain.Tags;
using XPShare.Domain.Stubs.Tags;

namespace XPShare.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddSingleton<IExperienceRepository, ExperienceRepository>();
            services.AddSingleton<IProjectRepository, ProjectRepository>();
            services.AddSingleton<ITagRepository, TagRepository>();
        }
    }
}
