using DynamicTimetableSolution.Application_Layer.Commands;
using DynamicTimetableSolution.Services_Layer.Interfaces;
using MediatR;

namespace DynamicTimetableSolution.Application_Layer.Handlers
{
    public class InsertSubjectsCommandHandler : IRequestHandler<InsertSubjectsCommand, bool>
    {
        private readonly ISubjectService _subjectService;

        public InsertSubjectsCommandHandler(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public async Task<bool> Handle(InsertSubjectsCommand request, CancellationToken cancellationToken)
        {
            await _subjectService.AddSubjectsAsync(request.Subjects);
            return true;
        }
    }
}