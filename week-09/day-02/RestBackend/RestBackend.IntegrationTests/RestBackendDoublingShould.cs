using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RestBackend.IntegrationTests
{
    public class RestBackendDoublingShould
    {
        private TestServer Server;
        private HttpClient Client;

        public RestBackendDoublingShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("doubling");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorMessage()
        {
            var response = await Client.GetAsync("doubling");

            Assert.Equal("{\"error\":\"Please provide an input!\"}", await response.Content.ReadAsStringAsync());
        }

        [Fact]
        public async Task WhenNumberEnteredReturnResult()
        {
            var response = await Client.GetAsync("doubling?input=55");
            var resultMessage = await response.Content.ReadAsStringAsync();

            Assert.True(resultMessage.ToString().Contains("result"));
        }
    }
}
