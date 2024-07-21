using LangDuc.LearningService.Application.Common.Dtos;
using LangDuc.LearningService.Application.Common.Services;
using LangDuc.LearningService.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LangDuc.LearningService.Api.Controllers
{
    public class LearningPathController(ILearningPathService learningPathService) : BaseController
    {
        [HttpPost]
        public async Task<LearningPath?> CreateLearingPath([FromBody] CreateLeariningPathDto learningPath, CancellationToken cancellationToken)
        {
            var result = await learningPathService.CreateLearningPathAsync(learningPath, cancellationToken);

            return result;
        }
    }
}
