using Microsoft.EntityFrameworkCore;
using BookingAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//This one is for the HotelBooking Memory database DbContext
builder.Services.AddDbContext<ApiContext>(opt => opt.UseInMemoryDatabase("BookingDb"));
//This one is for the Issue SqlServer DbContext
builder.Services.AddDbContext<IssueDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
