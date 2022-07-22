using Microsoft.EntityFrameworkCore;
using Models.Entities;
namespace DAL.DbContexts
{
    public  class SchoolMassDbContext:DbContext
    {

        public DbSet<Department> Deparments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentLesson> StudentLessons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer("Server=DESKTOP-FUVC3V6\\SQLExpress;Database=SchoolMass;Trusted_Connection=True;"));
        }
    }
}
