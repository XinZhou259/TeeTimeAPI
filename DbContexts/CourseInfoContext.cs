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
                },
                new Course("Red Woods Golf Club", "https://www.redwoodsgolfclub.com/")
                {
                    Id = 4,
                },
                new Course("Hazelmere Golf Club", "https://www.hazelmeregolfclub.com/")
                {
                    Id = 5,
                },
                 new Course("Morgan Creek Golf Club", "https://www.morgancreekgolfclub.com/")
                 {
                     Id = 6,
                 }
            );

            modelBuilder.Entity<TeeTime>().HasData(
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10, 30, 0), 4, 200)
                {
                    Id = 1,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10, 50, 0), 3, 200)
                {
                    Id = 2,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(12, 30, 0), 4, 180)
                {
                    Id = 3,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(12, 40, 0), 4, 180)
                {
                    Id = 4,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 10, 0), 3, 150)
                {
                    Id = 5,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 30, 0), 4, 150)
                {
                    Id = 6,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(11, 20, 0), 4, 150)
                {
                    Id = 7,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 0, 0), 4, 120)
                {
                    Id = 8,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(15, 50, 0), 2, 100)
                {
                    Id = 9,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(11, 40, 0), 4, 150)
                {
                    Id = 10,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 20, 0), 3, 120)
                {
                    Id = 11,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(16, 0, 0), 4, 100)
                {
                    Id = 12,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10, 20, 0), 4, 200)
                {
                    Id = 13,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(13, 30, 0), 4, 180)
                {
                    Id = 14,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(15, 40, 0), 2, 130)
                {
                    Id = 15,
                    CourseId = 3
                },
                 new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(10, 40, 0), 4, 200)
                 {
                     Id = 16,
                     CourseId = 3
                 },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(14, 0, 0), 4, 180)
                {
                    Id = 17,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 01), new TimeSpan(16, 0, 0), 4, 130)
                {
                    Id = 18,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 30, 0), 4, 200)
                {
                    Id = 19,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 50, 0), 3, 200)
                {
                    Id = 20,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(12, 30, 0), 4, 180)
                {
                    Id = 21,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 40, 0), 4, 200)
                {
                    Id = 22,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(11, 20, 0), 4, 200)
                {
                    Id = 23,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(12, 40, 0), 2, 180)
                {
                    Id = 24,
                    CourseId = 1
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(11, 20, 0), 4, 150)
                {
                    Id = 25,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(14, 0, 0), 4, 120)
                {
                    Id = 26,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(15, 50, 0), 2, 100)
                {
                    Id = 27,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(12, 0, 0), 4, 150)
                {
                    Id = 28,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(14, 20, 0), 4, 120)
                {
                    Id = 29,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(16, 10, 0), 2, 100)
                {
                    Id = 30,
                    CourseId = 2
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 20, 0), 4, 200)
                {
                    Id = 31,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(13, 30, 0), 4, 150)
                {
                    Id = 32,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(15, 40, 0), 2, 130)
                {
                    Id = 33,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(10, 30, 0), 3, 200)
                {
                    Id = 34,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(13, 10, 0), 4, 150)
                {
                    Id = 35,
                    CourseId = 3
                },
                new TeeTime(new DateTime(2024, 09, 02), new TimeSpan(16, 10, 0), 1, 130)
                {
                    Id = 36,
                    CourseId = 3
                }
            );
        }
    }
}
