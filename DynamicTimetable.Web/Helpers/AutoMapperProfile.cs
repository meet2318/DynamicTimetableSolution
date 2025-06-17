using AutoMapper;
using DynamicTimetable.Web.Models;
using DynamicTimetableSolution.Models;

namespace DynamicTimetable.Web.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // ViewModel to Model
            CreateMap<TimeTableInputViewModel, TimeTableInput>();
            CreateMap<SubjectHoursViewModel, Subject>();

            // Model to ViewModel
            CreateMap<Subject, SubjectHoursViewModel>();
        }
    }
}