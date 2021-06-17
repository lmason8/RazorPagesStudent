using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesStudent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesStudentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesStudentContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        FirstName = "Barney",
                        LastName = "T.Dinosaur",
                        CertifiedDate = DateTime.Parse("1989-2-12"),
                        Location = "Chicago",
                        TandF = 7.99M,
                        Program = "UC_WDES"
                    },

                    new Student
                    {
                        FirstName = "Terry",
                        LastName = "Dactyl",
                        CertifiedDate = DateTime.Parse("1989-2-12"),
                        Location = "Rio di Janero",
                        TandF = 7.95M,
                        Program = "UC_WDES"
                    },

                    new Student
                    {
                        FirstName = "Winnie",
                        LastName = "T.Pooh",
                        CertifiedDate = DateTime.Parse("1989-2-12"),
                        Location = "Cleveland",
                        TandF = 7.93M,
                        Program = "UC_WDES"
                    },

                    new Student
                    {
                        FirstName = "Kanga",
                        LastName = "Roo",
                        CertifiedDate = DateTime.Parse("1989-2-12"),
                        Location = "Sydney",
                        TandF = 7.91M,
                        Program = "UC_WDES"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}