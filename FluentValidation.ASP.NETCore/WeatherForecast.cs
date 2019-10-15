using System;

namespace FluentValidation.ASP.NETCore
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    public class WeatherForecastValidator : AbstractValidator<WeatherForecast>
    {
        public WeatherForecastValidator()
        {
            RuleFor(x => x.TemperatureC).NotNull();
            RuleFor(x => x.Summary).Length(0, 10);
        }
    }
}
