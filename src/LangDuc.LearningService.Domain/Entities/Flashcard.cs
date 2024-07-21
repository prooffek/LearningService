using LangDuc.LearningService.Domain.Common.enums;
using LangDuc.LearningService.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace LangDuc.LearningService.Domain.Entities
{
    public class Flashcard : ReferencedEntityBase
    {
        [Required]
        public FlashcardStatus Status { get; set; }

        public DateTime? LastSeenOn { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1024)]
        public string MainValue { get; set; }

        [Required]
        public Guid LearningPathId { get; set; }

        public ICollection<Property> Properties { get; set; } = [];
    }
}
