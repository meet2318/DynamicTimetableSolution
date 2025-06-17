using DynamicTimetableSolution.Models;
using MediatR;

namespace DynamicTimetableSolution.Application_Layer.Commands
{
    public class InsertSubjectsCommand : IRequest<bool>
    {
        public List<Subject> Subjects { get; set; }

        public InsertSubjectsCommand(List<Subject> subjects)
        {
            Subjects = subjects;
        }
    }
}