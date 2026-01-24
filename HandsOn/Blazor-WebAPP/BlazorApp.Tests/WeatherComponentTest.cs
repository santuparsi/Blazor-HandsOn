using BlazorApp.Web.Components;
using BlazorApp.Web.Services;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Tests
{
    public class WeatherComponentTest:BunitContext
    {
        [Fact]
        public void Async_Component_Renders_Data()
        {
            Services.AddSingleton<IWeatherService, FakeWeatherService>();

            var cut = Render<WeatherComponent>();

            cut.WaitForAssertion(() =>
                Assert.Contains("25", cut.Markup)
            );
        }

    }
}
