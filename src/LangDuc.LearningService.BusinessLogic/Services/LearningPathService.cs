using AutoMapper;
using LangDuc.LearningService.Application.Common.Dtos;
using LangDuc.LearningService.Application.Common.Repositories;
using LangDuc.LearningService.Application.Common.Services;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.BusinessLogic.Services
{
    public class LearningPathService(ILearningPathRepository learningPathRepository, IMapper mapper) : ILearningPathService
    {
        public async Task<LearningPath?> CreateLearningPathAsync(CreateLeariningPathDto dto, CancellationToken cancellationToken)
        {
            var learningPath = mapper.Map<LearningPath>(dto);
            learningPathRepository.Add(learningPath);
            await learningPathRepository.SaveChangesAsync(cancellationToken);

            return await learningPathRepository.GetByIdAsync(learningPath.Id, cancellationToken);
        }
    }
}
