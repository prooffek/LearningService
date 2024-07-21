using AutoMapper;
using LangDuc.Common.Persistence.Repositories;
using LangDuc.LearningService.Application.Common.Repositories;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.Persistence.Repository
{
    public class PropertyRepository : RepositoryBase<Property, Guid>, IPropertyRepository
    {
        public PropertyRepository(AppDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        protected override IQueryable<Property> Query => Entity;
    }
}
