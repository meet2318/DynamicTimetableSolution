using AutoMapper;
using DynamicTimetable.Web.Models;
using DynamicTimetableSolution.DTOs;
using DynamicTimetableSolution.Models;

namespace DynamicTimetable.Web.Services
{
    public class ApiClientService : IApiClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IMapper _mapper;

        public ApiClientService(HttpClient httpClient, IMapper mapper)
        {
            _httpClient = httpClient;
            _mapper = mapper;
        }

        public async Task<bool> AddSubjectsAsync(List<SubjectHoursViewModel> subjects)
        {
            var modelList = _mapper.Map<List<Subject>>(subjects);
            var response = await _httpClient.PostAsJsonAsync("api/TimeTable/AddSubjects", modelList);
            return response.IsSuccessStatusCode;
        }

        public async Task<List<SubjectHoursViewModel>> GetSubjectsAsync()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Subject>>("api/TimeTable/GetSubjects");
            return _mapper.Map<List<SubjectHoursViewModel>>(result ?? new List<Subject>());
        }

        public async Task<List<List<string>>> GenerateTimeTableAsync(TimeTableInputViewModel input, List<SubjectHoursViewModel> subjects)
        {
            var dto = new TimeTableGenerateRequestDto
            {
                Input = _mapper.Map<TimeTableInput>(input),
                Subjects = _mapper.Map<List<Subject>>(subjects)
            };

            var response = await _httpClient.PostAsJsonAsync("api/TimeTable/Generate", dto);
            if (!response.IsSuccessStatusCode)
                return new List<List<string>>();

            var result = await response.Content.ReadFromJsonAsync<TimeTableResponseDto>();
            return result?.Table ?? new List<List<string>>();
        }
    }
}