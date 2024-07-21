namespace LangDuc.LearningService.Application.Common.Dtos
{
    public record CreateLeariningPathDto
    {
        public Guid Id { get; set; }
        public ICollection<CreateFlashcardDto> Flashcards { get; set; } = [];
    }
}
