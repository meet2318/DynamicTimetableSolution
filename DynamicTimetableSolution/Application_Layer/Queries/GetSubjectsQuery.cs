using DynamicTimetableSolution.Models;
using MediatR;

namespace DynamicTimetableSolution.Application_Layer.Queries
{
    public class GetSubjectsQuery : IRequest<List<Subject>> { }
}