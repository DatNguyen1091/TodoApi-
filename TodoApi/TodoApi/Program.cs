using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);

// Configure JSON options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.IncludeFields = true;
});

var app = builder.Build();

app.MapGet("/", () => new Todo { Name = "Walk dog", IsComplete = false });

app.Run();

class Todo
{
    // These are public fields instead of properties.
    public string? Name;
    public bool IsComplete;
}