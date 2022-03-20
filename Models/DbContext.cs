using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace network
{
    public class NetworkDbContext : DbContext
    {
        public DbSet<Note>? notes { get; set; }
        public DbSet<User>? users { get; set; }
        public DbSet<AuthenticateRequest>? authenticateRequests { get; set; }
        public DbSet<AuthenticateResponse>? authenticateResponses { get; set; }
        





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
            optionsBuilder.UseMySql("server=localhost;database=sahabt;user=root;port=3306;password=toortoor", serverVersion);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            NoteDatabaseBuilder.TableBuilder(modelBuilder);
        }
    }
}