using AutoMapper;
using DynamicTimetableSolution.Models;

namespace DynamicTimetableSolution.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Subject, Subject>();
            CreateMap<TimeTableInput, TimeTableInput>();
        }
    }
}