var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("MyCors", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();

app.UseCors("MyCors");
app.MapControllers();
app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});
app.Run();
