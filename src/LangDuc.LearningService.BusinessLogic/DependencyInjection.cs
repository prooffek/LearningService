using LangDuc.LearningService.Application.Common.Services;
using LangDuc.LearningService.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace LangDuc.LearningService.BusinessLogic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {
            services.AddScoped<ILearningPathService, LearningPathService>();

            return services;
        }
    }
}
