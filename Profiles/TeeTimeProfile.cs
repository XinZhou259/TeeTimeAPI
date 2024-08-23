using AutoMapper;

namespace TeeTimeAPI.Profiles
{
    public class TeeTimeProfile : Profile
    {
        public TeeTimeProfile()
        {
            CreateMap<Entities.TeeTime, Models.TeeTimeDto>();
            CreateMap<Models.TeeTimeForCreateDto, Entities.TeeTime>();
        }
    }
}
