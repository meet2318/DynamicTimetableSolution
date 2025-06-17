using DynamicTimetableSolution.Infrastructure_Layer.Data;
using DynamicTimetableSolution.Repositories_Layer.Implementations;
using DynamicTimetableSolution.Repositories_Layer.Interfaces;
using DynamicTimetableSolution.Services_Layer.Implementations;
using DynamicTimetableSolution.Services_Layer.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using DynamicTimetableSolution.Application_Layer.Handlers; // Must be correct
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ISubjectService, SubjectService>();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(InsertSubjectsCommandHandler).Assembly));
builder.Services.AddCors(options =>

builder.Services.AddAutoMapper(typeof(Program)));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
