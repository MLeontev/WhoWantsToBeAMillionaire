using Microsoft.EntityFrameworkCore;

namespace WhoWantsToBeAMillionaire.Models
{
    public class MillionaireDBContext : DbContext
    {
        public DbSet<Question> Questions { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        public MillionaireDBContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = WhoWantsToBeAMillionaire.db");
        }
    }
}
