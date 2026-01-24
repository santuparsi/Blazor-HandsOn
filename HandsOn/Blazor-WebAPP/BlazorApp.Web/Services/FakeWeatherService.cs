namespace BlazorApp.Web.Services
{
    public class FakeWeatherService : IWeatherService
    {
        public Task<int> GetTemperatureAsync() => Task.FromResult(25);
    }

}
