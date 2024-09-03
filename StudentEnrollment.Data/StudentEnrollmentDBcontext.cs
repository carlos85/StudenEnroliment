using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentEnrollment.Data.Configurations;


namespace StudentEnrollment.Data
{
    public class StudentEnrollmentDBcontext : IdentityDbContext
    {
        public StudentEnrollmentDBcontext(DbContextOptions<StudentEnrollmentDBcontext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new UserCourseConfiguration());
        }

        public DbSet<Course> Courses {get;set;}
        public DbSet<Student> GetStudents {get; set;}
        public DbSet<Enrollment> Enrollments {get; set;}  
    }
}