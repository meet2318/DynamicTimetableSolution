using DynamicTimetable.Web.Models;

namespace DynamicTimetable.Web.Services
{
    public interface IApiClientService
    {
        Task<bool> AddSubjectsAsync(List<SubjectHoursViewModel> subjects);
        Task<List<SubjectHoursViewModel>> GetSubjectsAsync();
        Task<List<List<string>>> GenerateTimeTableAsync(TimeTableInputViewModel input, List<SubjectHoursViewModel> subjects);
    }
}