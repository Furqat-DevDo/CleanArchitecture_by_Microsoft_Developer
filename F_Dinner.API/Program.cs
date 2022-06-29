using F_Dinner.API.Filters;
using F_Dinner.Application;
using F_Dinner.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
// builder.Services.AddControllers(options=>options.Filters.Add<ErrorHandlingFilterAttribute>());
builder.Services.
    AddApplication()
    .AddInfrastructure(builder.Configuration);
var app = builder.Build();

app.UseHttpsRedirection();
//app.UseMiddleware<ErrorHandlingMiddleWare>();
app.UseExceptionHandler("/error");
app.MapControllers();

app.Run();
