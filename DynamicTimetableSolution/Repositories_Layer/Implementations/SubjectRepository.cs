using DynamicTimetableSolution.Infrastructure_Layer.Data;
using DynamicTimetableSolution.Models;
using DynamicTimetableSolution.Repositories_Layer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DynamicTimetableSolution.Repositories_Layer.Implementations
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly AppDbContext _context;

        public SubjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task AddSubjectsAsync(List<Subject> subjects)
        {
            await _context.Subjects.AddRangeAsync(subjects);
            await _context.SaveChangesAsync();
        }
    }
}