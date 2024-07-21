using LangDuc.LearningService.Domain.Common.enums;
using LangDuc.LearningService.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace LangDuc.LearningService.Application.Common.Dtos
{
    public record CreateFlashcardDto
    {
        [Required]
        public Guid ReferenceId { get; set; }

        [Required]
        public FlashcardStatus Status { get; set; }

        public DateTime? LastSeenOn { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1024)]
        public string MainValue { get; set; }

        public ICollection<CreatePropertyDto> Properties { get; set; } = [];
    }
}
