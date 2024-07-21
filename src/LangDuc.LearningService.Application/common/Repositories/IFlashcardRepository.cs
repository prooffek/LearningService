﻿using LangDuc.Common.Application.Interfaces;
using LangDuc.LearningService.Domain.Entities;

namespace LangDuc.LearningService.Application.Common.Repositories
{
    public interface IFlashcardRepository : IRepositoryBase<Flashcard, Guid>
    {
    }
}