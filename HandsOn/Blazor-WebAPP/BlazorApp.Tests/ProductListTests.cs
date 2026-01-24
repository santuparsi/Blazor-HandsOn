using BlazorApp.Web.Components;
using BlazorApp.Web.Services;
using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace BlazorApp.Tests
{
    public class ProductListTests : BunitContext
    {
        [Fact]
        public void Products_Are_Rendered()
        {
            var productList = Render<ProductList>();
            Assert.Contains("Laptop", productList.Markup);
            Assert.Contains("Keyboard", productList.Markup);
            Assert.All(
    new[] { "Laptop", "Keyboard" },
    item => Assert.Contains(item, productList.Markup)
);
            Assert.True(
    productList.Markup.Contains("Laptop") &&
    productList.Markup.Contains("Keyboard")
);

        }


        [Fact]
        public void Products_Are_Rendered_From_Service()
        {
            var mockService = new Mock<IProductService>();
            mockService.Setup(s => s.GetProductsAsync())
                       .ReturnsAsync(["Laptop", "Keyboard"]);
            Services.AddSingleton(mockService.Object);
            var cut = Render<ProductList>();
            Assert.Contains("Laptop", cut.Markup);
            Assert.Contains("Keyboard", cut.Markup);
        }
        [Fact]
        public void LoginForm_ShowsValidationErrors()
        {
            var cut = Render<Login>();

            cut.Find("button").Click();

            cut.Markup.Contains("required");
        }

    }
}
