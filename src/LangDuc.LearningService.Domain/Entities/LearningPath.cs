using LangDuc.LearningService.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LangDuc.LearningService.Domain.Entities
{
    public class LearningPath : EntityBase
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override Guid Id { get => base.Id; set => base.Id = value; }
        public ICollection<Flashcard> Flashcards { get; set; } = [];
    }
}
