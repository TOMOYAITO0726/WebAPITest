using WebAPITest.Base;
using WebAPITest.Businesslogic;
using WebAPITest.DataAccess;
using WebAPITest.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DIÇê›íË
builder.Services.AddTransient<IHogeBusinesslogic<HogeInputModel, HogeResultModel>, HogeBusinesslogic<HogeInputModel, HogeResultModel>>();
builder.Services.AddTransient<HogeDataAccess, HogeDataAccess>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();