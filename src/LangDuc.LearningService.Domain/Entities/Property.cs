using LangDuc.LearningService.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace LangDuc.LearningService.Domain.Entities
{
    public class Property : ReferencedEntityBase
    {
        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Value { get; set; }

        [Required]
        public Guid FlashcardId { get; set; }
    }
}
