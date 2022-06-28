using F_Dinner.Application.Common.Interfaces.Authentication;
using F_Dinner.Application.Common.Interfaces.Services;
using F_Dinner.Infrastructure.Services;
using F_Dinner.Infrastucture.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace F_Dinner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
    ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IDateTimeProvider, DateTimeProvider>();
        return services;
    }
}