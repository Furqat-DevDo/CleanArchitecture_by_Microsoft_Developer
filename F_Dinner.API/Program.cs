using F_Dinner.Application;
using F_Dinner.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.
    AddApplication()
    .AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
