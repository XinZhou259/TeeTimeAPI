using Microsoft.EntityFrameworkCore;
using TeeTimeAPI.Entities;

namespace TeeTimeAPI.DbContexts
{
    public class CourseInfoContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<TeeTime> TeeTimes { get; set; }

        public CourseInfoContext(DbContextOptions<CourseInfoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(
                new Course("The Links at Terranea", "https://www.terranea.com/golf")
                {
                    Id = 1,                    
                },
                new Course("Trump National Golf Club", "https://www.trumpnationallosangeles.com/")
                {
                    Id = 2,
                },
                new Course("Northview Golf Club", "https://www.northviewgolfclub.com/")
                {
                    Id = 3,
                }
            );

            modelBuilder.Entity<TeeTime>().HasData(
                new TeeTime(new DateTime(2024,09,01),new TimeSpan(10,30,0), 4, 200)
                {
                    Id = 1,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10,50, 0), 3, 200)
                {
                    Id = 2,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(12, 30, 0), 4, 150)
                {
                    Id = 3,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(11, 20, 0), 4, 150)
                {
                    Id = 4,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 0, 0), 4, 120)
                {
                    Id = 5,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(15, 50, 0), 2, 100)
                {
                    Id = 6,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10, 20, 0), 4, 200)
                {
                    Id = 7,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(13, 30, 0), 4, 150)
                {
                    Id = 8,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(15, 40, 0), 2, 100)
                {
                    Id = 9,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 30, 0), 4, 200)
                {
                    Id = 10,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 50, 0), 3, 200)
                {
                    Id = 11,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(12, 30, 0), 4, 150)
                {
                    Id = 12,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(11, 20, 0), 4, 150)
                {
                    Id = 13,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(14, 0, 0), 4, 120)
                {
                    Id = 14,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(15, 50, 0), 2, 100)
                {
                    Id = 15,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 20, 0), 4, 200)
                {
                    Id = 16,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(13, 30, 0), 4, 150)
                {
                    Id = 17,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(15, 40, 0), 2, 100)
                {
                    Id = 18,
                    CourseId = 3
                }
            );
        }
    }
}
