using TeeTimeAPI.Models;

namespace TeeTimeAPI
{
    public class CoursesDataStore
    {
        public List<CourseDto> Courses { get; set; }
        public static CoursesDataStore Current { get; } = new CoursesDataStore();

        public CoursesDataStore()
        {
            Courses = new List<CourseDto>
            {
                new CourseDto {
                    Id = 1,
                    CourseName = "Morgan Creak",
                    CourseURL = "www.morgancreak.com",
                    TeeTimes = new List<TeeTimesDto>
                        {
                            new TeeTimesDto { Id = 1, Date = "2024-09-01", Time = "10:00", NumberOfPlayer = "4", Price = 200 },
                            new TeeTimesDto { Id = 2, Date = "2024-09-01", Time = "11:00", NumberOfPlayer = "3", Price = 200 },
                            new TeeTimesDto { Id = 3, Date = "2024-09-01", Time = "12:00", NumberOfPlayer = "4", Price = 200 }
                        },
                },
                new CourseDto {
                    Id = 2,
                    CourseName = "Hazelmere",
                    CourseURL = "www.Hazelmere.com",
                    TeeTimes = new List<TeeTimesDto>
                        {
                            new TeeTimesDto { Id = 4, Date = "2024-09-01", Time = "10:00", NumberOfPlayer = "4", Price = 150 },
                            new TeeTimesDto { Id = 5, Date = "2024-09-01", Time = "11:00", NumberOfPlayer = "4", Price = 150 },
                            new TeeTimesDto { Id = 6, Date = "2024-09-01", Time = "12:00", NumberOfPlayer = "2", Price = 150 }
                        },
                },
                new CourseDto { 
                    Id = 3, 
                    CourseName = "Northview", 
                    CourseURL = "www.Northview.com",
                    TeeTimes = new List<TeeTimesDto>
                        {
                            new TeeTimesDto { Id = 7, Date = "2024-09-01", Time = "10:00", NumberOfPlayer = "1", Price = 180 },
                            new TeeTimesDto { Id = 8, Date = "2024-09-01", Time = "11:00", NumberOfPlayer = "4", Price = 180 },
                            new TeeTimesDto { Id = 9, Date = "2024-09-01", Time = "12:00", NumberOfPlayer = "4", Price = 180 }
                        },
                }
            };
        }
    }
}
