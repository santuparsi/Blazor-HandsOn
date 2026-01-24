using BlazorApp.Web.Components;
using BlazorApp.Web.Services;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Tests
{
    public class CounterServerTests: BunitContext
    {
        [Fact]
        public void Component_Uses_Injected_Service()
        {
            Services.AddSingleton<CounterService>();

            var cut = Render<CounterWithService>();

            cut.Find("button").Click();

            Assert.Contains("1", cut.Markup);
        }

    }
}
