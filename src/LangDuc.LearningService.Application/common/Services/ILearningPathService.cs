using LangDuc.LearningService.Application.Common.Dtos;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.Application.Common.Services
{
    public interface ILearningPathService
    {
        Task<LearningPath?> CreateLearningPathAsync(CreateLeariningPathDto dto, CancellationToken cancellationToken);
    }
}
