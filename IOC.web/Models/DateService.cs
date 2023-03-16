namespace IOC.web.Models
{
    public class DateService : IScopedDateService,ITransientDateService,ISingletonDateService
    {
        private readonly ILogger<DateService> _logger;
        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DateService constructor'ına girdi.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
