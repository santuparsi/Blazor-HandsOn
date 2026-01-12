using HandsOnBlazorInvokeAPI;
using HandsOnBlazorInvokeAPI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Text.Json;
namespace HandsOnBlazorInvokeAPI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:64257/") });
            builder.Services.AddScoped<IMovieService, MovieService>();
           

            await builder.Build().RunAsync();
        }
    }
}
