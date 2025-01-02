using Microsoft.EntityFrameworkCore;

namespace Relations.Models
{
    public class AppDbContext:DbContext
    {
        //public AppDbContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=relationsdb;Trusted_Connection=True;");
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherProfile> TeacherProfiles { get; set; }
    }
}
