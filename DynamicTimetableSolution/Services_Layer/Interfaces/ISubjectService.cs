using DynamicTimetableSolution.Models;

namespace DynamicTimetableSolution.Services_Layer.Interfaces
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task AddSubjectsAsync(List<Subject> subjects);
    }
}