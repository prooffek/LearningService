using System.ComponentModel.DataAnnotations;

namespace LangDuc.LearningService.Application.Common.Dtos
{
    public record CreatePropertyDto
    {
        [Required]
        public Guid ReferenceId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(1024)]
        public string Value { get; set; }
    }
}
