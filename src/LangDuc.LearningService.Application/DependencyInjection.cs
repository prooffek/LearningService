using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace LangDuc.LearningService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
