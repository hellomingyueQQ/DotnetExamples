
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebApiApp.Tests
{
    [TestClass]
    public class WeatherForecastControllerTest
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public WeatherForecastControllerTest()
        {
            _factory = new WebApplicationFactory<Startup>();
        }

        [TestMethod]
        public async Task WeatherForecastControllerTest_Get_WeatherForecast()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/WeatherForecast");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
