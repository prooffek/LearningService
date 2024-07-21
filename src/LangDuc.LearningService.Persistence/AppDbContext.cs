using LangDuc.LearningService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LangDuc.LearningService.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Flashcard> Flashcards { get; set; }
        public DbSet<LearningPath> LearningPaths { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
