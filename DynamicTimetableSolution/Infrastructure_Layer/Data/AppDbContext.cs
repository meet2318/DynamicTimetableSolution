using DynamicTimetableSolution.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicTimetableSolution.Infrastructure_Layer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Subject> Subjects { get; set; }
        public DbSet<TimeTableInput> TimeTableInputs { get; set; }

        // If you decide to store generated timetable cells:
        // public DbSet<TimeTableCell> TimeTableCells { get; set; }
    }
}