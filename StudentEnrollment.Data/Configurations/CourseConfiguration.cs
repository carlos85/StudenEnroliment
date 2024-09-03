using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentEnrollment.Data.Configurations
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
             builder.HasData(
                new Course
                {
                    Id=1,
                    Title ="minimal Api Development",
                    Credits = "3" 
                },
                new Course{
                    Id=2,
                    Title ="Ultimate Api Development",
                    Credits = "5"
                    
                }
            );
        }
    }

    internal class UserCourseConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
          builder.HasData(
             new IdentityRole
             {
                Name = "ADMINISTRATOR"
             },
             new IdentityRole
             {
                Name = "USER"
             }); 
        }
    }
}