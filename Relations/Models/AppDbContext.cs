using Microsoft.EntityFrameworkCore;
using Relations.Models.OneToMany;
using Relations.Models.OneToOnes;

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

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
