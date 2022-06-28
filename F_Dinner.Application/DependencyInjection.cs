using F_Dinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace F_Dinner.Application;
public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
       services.AddScoped<IAuthenticationService, AuthenticationService>();
       return services;
    }
}