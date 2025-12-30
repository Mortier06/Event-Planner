

using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Persistence.Entities;


var builder = WebApplication.CreateBuilder(args);

string connectionString = "Server=127.0.0.1;Port=8555;Database=EventPlanner;User=eventplanner;Password=eventplanner123;SslMode=Preferred;";

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

//db
builder.Services.AddDbContext<EventDBContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString(connectionString),
        new MySqlServerVersion(new Version(8, 0, 33))
    )
);





var app = builder.Build();



app.UseHttpsRedirection();


app.MapControllers();
app.Run();


