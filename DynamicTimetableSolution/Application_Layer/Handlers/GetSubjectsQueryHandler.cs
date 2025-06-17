using DynamicTimetableSolution.Application_Layer.Queries;
using DynamicTimetableSolution.Models;
using DynamicTimetableSolution.Services_Layer.Interfaces;
using MediatR;

namespace DynamicTimetableSolution.Application_Layer.Handlers
{
    public class GetSubjectsQueryHandler : IRequestHandler<GetSubjectsQuery, List<Subject>>
    {
        private readonly ISubjectService _subjectService;

        public GetSubjectsQueryHandler(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public async Task<List<Subject>> Handle(GetSubjectsQuery request, CancellationToken cancellationToken)
        {
            return await _subjectService.GetAllSubjectsAsync();
        }
    }
}