using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using F_Dinner.Application.Common.Interfaces.Authentication;
using F_Dinner.Application.Common.Interfaces.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace F_Dinner.Infrastucture.Authentication;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettings _jwtSettings;

    public JwtTokenGenerator(
                            IDateTimeProvider dateTimeProvider,
                            IOptions<JwtSettings> jwtSettingsoptions)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettings = jwtSettingsoptions.Value;
    }

    public string GenerateToken(Guid userId, string Firstname, string Lastname)
    {
        var signinCredentials = new SigningCredentials(
            new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
            SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, Firstname),
            new Claim(JwtRegisteredClaimNames.FamilyName, Lastname),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var SecurityToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettings.Expiration),
            claims: claims,
            signingCredentials: signinCredentials);
            
        return new JwtSecurityTokenHandler().WriteToken(SecurityToken);
    }
}
