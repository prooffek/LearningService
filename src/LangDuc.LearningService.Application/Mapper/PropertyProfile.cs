using AutoMapper;
using LangDuc.LearningService.Application.Common.Dtos;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.Application.Mapper
{
    public class PropertyProfile : Profile
    {
        public PropertyProfile()
        {
            CreateMap<CreatePropertyDto, Property>();
        }
    }
}
