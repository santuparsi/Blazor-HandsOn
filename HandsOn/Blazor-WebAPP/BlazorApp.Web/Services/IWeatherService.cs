namespace BlazorApp.Web.Services
{
    public interface IWeatherService
    {
        Task<int> GetTemperatureAsync();
    }
}
