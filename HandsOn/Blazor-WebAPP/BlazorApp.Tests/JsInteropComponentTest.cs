using BlazorApp.Web.Components;
using Bunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Tests
{
    public class JsInteropComponentTest:BunitContext
    {
        [Fact]
        public void AlertIsCalled()
        {
            JSInterop.SetupVoid("alert", "Hello");// Setup JS interop call

            var cut = Render<JsInterop>();

            cut.Find("button").Click();

            JSInterop.VerifyInvoke("alert");
        }

    }
}
