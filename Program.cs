using OrderApi.Services;
using OrderApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<OrderService>();

var app = builder.Build();

app.MapGet("/orders", (OrderService service) =>
{
    return service.GetAll();
});

app.MapPost("/orders", (OrderService service, Order order) =>
{
    service.Add(order);
    return Results.Ok(order);
});

app.Run();