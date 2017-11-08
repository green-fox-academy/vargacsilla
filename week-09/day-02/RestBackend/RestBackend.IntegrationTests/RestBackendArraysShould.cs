using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace RestBackend.IntegrationTests
{
    public class RestBackendArraysShould
    {
        private TestServer Server;
        private HttpClient Client;

        public RestBackendArraysShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOk()
        {
            var response = await Client.GetAsync("arrays");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
