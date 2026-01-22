using Bunit;
using Xunit;
using BlazorApp.Web.Components;
using BlazorApp.Web.Components.Pages;
namespace BlazorApp.Tests
{
    public class CounterTests:BunitContext
    {
        [Fact]
        public void CounterStartAtZero()
        {
            //Act
            var cut = Render<Counter>();
            //Assert
            Assert.Contains("Current count: 0", cut.Markup);
        }
        [Fact]
        public void ClickingButtonIncrementCount()
        {
            //act
            var cut= Render<Counter>();
            //arrange
            cut.Find("button").Click();
           
            //Assert
            Assert.Contains("Current Count:1", cut.Markup);

        }

    }   
}
