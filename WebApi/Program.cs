using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", () => Results.Ok(new { Message = "Hello from Web API" }));

app.MapGet(
    "/api/values/{id:int}",
    (int id) =>
    {
        var values = new[] { "value1", "value2", "value3" };
        if (id < 0 || id >= values.Length)
            return Results.NotFound();
        return Results.Ok(values[id]);
    }
);

app.MapPost(
    "/api/echo",
    (HttpRequest request) =>
    {
        return Results.Ok(new { Received = request.QueryString.Value });
    }
);

app.Run();
