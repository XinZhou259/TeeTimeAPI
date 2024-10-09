using AutoMapper;

namespace TeeTimeAPI.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile() 
        { 
            CreateMap<Entities.Course, Models.CourseDto>();
            CreateMap<Entities.Course, Models.CourseWithTeeTimeDto>();
            CreateMap<Models.CourseForCreateDto, Entities.Course>();
            CreateMap<Models.CourseForUpdateDto, Entities.Course>();    
        }

    }
}
