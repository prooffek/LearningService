using AutoMapper;
using LangDuc.Common.Persistence.Repositories;
using LangDuc.LearningService.Application.Common.Repositories;
using LangDuc.LearningService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LangDuc.LearningService.Persistence.Repository
{
    public class LearningPathRepository : RepositoryBase<LearningPath, Guid>, ILearningPathRepository
    {
        protected override IQueryable<LearningPath> Query => Entity
            .Include(l => l.Flashcards)
                .ThenInclude(f => f.Properties);

        public LearningPathRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
