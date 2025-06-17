using AutoMapper;
using DynamicTimetableSolution.Application_Layer.Commands;
using DynamicTimetableSolution.Application_Layer.Queries;
using DynamicTimetableSolution.DTOs;
using DynamicTimetableSolution.Helpers;
using DynamicTimetableSolution.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DynamicTimetableSolution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TimeTableController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TimeTableController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("AddSubjects")]
        public async Task<IActionResult> AddSubjects([FromBody] List<Subject> subjects)
        {
            var command = new InsertSubjectsCommand(subjects);
            var result = await _mediator.Send(command);
            return result ? Ok("Subjects inserted successfully") : BadRequest("Insert failed");
        }

        [HttpGet("GetSubjects")]
        public async Task<IActionResult> GetSubjects()
        {
            var result = await _mediator.Send(new GetSubjectsQuery());
            return Ok(result);
        }

        [HttpPost("Generate")]
        public async Task<IActionResult> Generate([FromBody] TimeTableGenerateRequestDto input)
        {
            int totalHours = input.Input.TotalHours;
            int allocatedHours = input.Subjects.Sum(s => s.TotalHours);

            if (totalHours != allocatedHours)
                return BadRequest("Total subject hours must equal total weekly hours.");

            var timetable = TimetableGenerator.GenerateTimetable(
                input.Input.WorkingDays,
                input.Input.SubjectsPerDay,
                input.Subjects
            );

            var response = new TimeTableResponseDto { Table = timetable };
            return Ok(response);
        }
    }
}