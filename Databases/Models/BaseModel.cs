using Microsoft.EntityFrameworkCore;

namespace DungeonWiki.Databases.Models
{
    public class WikiDbContext : DbContext
    {
        private readonly string _databaseFile;
        public DbSet<Base> Base { get; set; }

        public WikiDbContext(string databaseFile)
        {
            _databaseFile = databaseFile;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={_databaseFile}");
        }
    }

    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
