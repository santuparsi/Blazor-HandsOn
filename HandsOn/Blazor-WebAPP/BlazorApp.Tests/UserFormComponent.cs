using BlazorApp.Web.Components;
using Bunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp.Tests
{
    public class UserFormComponent:BunitContext
    {
        [Fact]
        public void Form_Submits_When_Valid()
        {
            var cut = Render<UserForm>();

            cut.Find("input").Change("San");
            cut.Find("form").Submit();
        }

    }
}
