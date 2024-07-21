using LangDuc.LearningService.Application;
using LangDuc.LearningService.BusinessLogic;
using LangDuc.LearningService.Persistence;
using LangDuc.LearningService.Persistence.StaticData;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
var connectionString = configuration.GetConnectionString(DbContextSD.SqlService);

// Add services to the container.
services.AddApplication()
    .AddBusinessLogic()
    .AddPersistence(connectionString);

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
