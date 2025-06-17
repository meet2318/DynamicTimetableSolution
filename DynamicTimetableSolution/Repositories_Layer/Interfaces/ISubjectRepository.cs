using DynamicTimetableSolution.Models;

namespace DynamicTimetableSolution.Repositories_Layer.Interfaces
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task AddSubjectsAsync(List<Subject> subjects);
    }
}