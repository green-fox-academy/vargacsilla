using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace CalorieApp.IntegrationTests2
{
    public class CalorieTableShould
    {
        private TestServer Server;
        private HttpClient Client;

        public CalorieTableShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ShouldReturnOk()
        {
            var response = await Client.GetAsync("drax");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
