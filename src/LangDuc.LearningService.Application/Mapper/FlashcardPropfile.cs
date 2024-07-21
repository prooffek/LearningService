using AutoMapper;
using LangDuc.LearningService.Application.Common.Dtos;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.Application.Mapper
{
    public class FlashcardPropfile : Profile
    {
        public FlashcardPropfile()
        {
            CreateMap<CreateFlashcardDto, Flashcard>();
        }
    }
}
