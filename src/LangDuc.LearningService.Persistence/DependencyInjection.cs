using LangDuc.LearningService.Application.Common.Repositories;
using LangDuc.LearningService.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace LangDuc.LearningService.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string? connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString)) 
                throw new NullReferenceException("[LearningService.Persistence] Connection string cannot be null or whitespace");

            services.AddSqlServer<AppDbContext>(connectionString);
            services.AddScoped<AppDbContext>();

            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IFlashcardRepository, FlashcardRepository>();
            services.AddScoped<ILearningPathRepository, LearningPathRepository>();

            return services;
        }
    }
}
