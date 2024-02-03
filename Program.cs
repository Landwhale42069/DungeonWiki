using DungeonWiki.Databases.Models;
using DungeonWiki.Utilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}"
);

app.MapControllers();

var dbManager = new DatabaseManager();
var poopus = dbManager.GetDatabase("poopus");
poopus.Create();

app.Run();
