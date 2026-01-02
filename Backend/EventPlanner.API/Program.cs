

using System.Text.Json.Serialization;
using API.Contracts.Logs;
using Domain.Services.Services;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using Percistence.Repositories;
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

builder.Services.AddScoped<ILocatieService, LocatieService>();
builder.Services.AddScoped<ILocatieRepository, LocatieRepository>();
builder.Services.AddScoped<ILoggingService, LoggingService>();
builder.Services.AddScoped<ILoggingRepository, LoggingRepository>();

//mongodb
// var mongoClient = new MongoClient("mongodb://localhost/27027");

// const string databaseName = "School";
// var dbExists = mongoClient.ListDatabaseNames().ToList().Contains(databaseName);
// if(!dbExists) throw new Exception("database not found");
// var database = mongoClient.GetDatabase(databaseName);

// const string collecitonName = "EventPlanner";
// var collectionExists = database.ListCollectionNames().ToList().Contains(collecitonName);
// if(!collectionExists) throw new Exception("collection bestaat niet");
// var collection = database.GetCollection<LogResponseContract>(collecitonName);

builder.Services.AddMongoDB<MongoDBContext>(new MongoClient("mongodb://localhost:27017"), "School");


var app = builder.Build();



app.UseHttpsRedirection();


app.MapControllers();
app.Run();


