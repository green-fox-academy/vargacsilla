using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RestBackend.IntegrationTests
{
    public class RestBackendGreeterShould
    {
        private TestServer Server;
        private HttpClient Client;

        public RestBackendGreeterShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOk()
        {
            var response = await Client.GetAsync("greeter");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ReturnErrorMessage_WithoutInput()
        {
            var response = await Client.GetAsync("greeter");
            var responseMessage = await response.Content.ReadAsStringAsync();

            Assert.True(responseMessage.Contains("error"));
        }

        [Fact]
        public async Task ReturnWelcomeMessage()
        {
            var response = await Client.GetAsync("greeter?name=Csicsi&title=queen");
            var responseMessage = await response.Content.ReadAsStringAsync();

            Assert.True(responseMessage.Contains("welcome_message"));
        }
    }
}
