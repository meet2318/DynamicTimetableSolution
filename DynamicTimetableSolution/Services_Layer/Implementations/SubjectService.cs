using DynamicTimetableSolution.Models;
using DynamicTimetableSolution.Repositories_Layer.Interfaces;
using DynamicTimetableSolution.Services_Layer.Interfaces;

namespace DynamicTimetableSolution.Services_Layer.Implementations
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            _subjectRepository = subjectRepository;
        }

        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            return await _subjectRepository.GetAllSubjectsAsync();
        }

        public async Task AddSubjectsAsync(List<Subject> subjects)
        {
            await _subjectRepository.AddSubjectsAsync(subjects);
        }
    }
}