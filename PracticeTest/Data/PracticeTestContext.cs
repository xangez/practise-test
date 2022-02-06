using Microsoft.EntityFrameworkCore;
using PracticeTest.Models;

namespace PracticeTest.Data;

public class PracticeTestContext : DbContext
{
    public PracticeTestContext()
    { }
    public PracticeTestContext(DbContextOptions<PracticeTestContext> options) : base(options)
    { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseAssignment> CourseAssignments { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<OfficeAssignment> OfficeAssignments { get; set; }
    public DbSet<Student> Students { get; set; }

    // Fluent-API.
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //convert enum to string
        builder.Entity<Enrollment>().Property(e => e.Grade).HasConversion(v => v.ToString(), v => (Grade)Enum.Parse(typeof(Grade), v));

        // Setup composite primary key.
        builder.Entity<CourseAssignment>().HasKey(x => new { x.InstructorID, x.CourseID }); 

        // computed column for full name
        builder.Entity<Student>()
            .Property(p => p.FullName)
            .HasComputedColumnSql("[FirstMidName] + ' ' + [LastName]");

        builder.Entity<Instructor>()
            .Property(p => p.FullName)
            .HasComputedColumnSql("[FirstMidName] + ' ' + [LastName]");

    }
}
