using F_Dinner.Application.Common.Interfaces.Services;

namespace F_Dinner.Infrastructure.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
