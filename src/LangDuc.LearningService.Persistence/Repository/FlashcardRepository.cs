using AutoMapper;
using LangDuc.Common.Persistence.Repositories;
using LangDuc.LearningService.Application.Common.Repositories;
using LangDuc.LearningService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LangDuc.LearningService.Persistence.Repository
{
    public class FlashcardRepository : RepositoryBase<Flashcard, Guid>, IFlashcardRepository
    {
        public FlashcardRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Flashcard> Query => Entity
            .Include(f => f.Properties);
    }
}
