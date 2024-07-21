using LangDuc.Common.Persistence.DbContextFactory;
using LangDuc.LearningService.Persistence.StaticData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LangDuc.LearningService.Persistence
{
    public class AppDbContextFactory : AppDbContextFactoryBase<AppDbContext>
    {
        protected override string ConnectionStringPath => DbContextSD.SqlService;

        public override AppDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder optionsBuilder = new();
            optionsBuilder.UseSqlServer(DefaultConfiguration.GetConnectionString(ConnectionStringPath));

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
