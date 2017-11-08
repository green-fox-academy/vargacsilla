using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestBackend.IntegrationTests
{
    class RestBackendGreeterShould
    {
        private TestServer Server;
        private HttpClient Client;

        public RestBackendGreeterShould()
        {
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task ReturnOkStatus()
        {
            var response = await Client.GetAsync("greeter");
            var responseMessage = await response.Content.ReadAsStringAsync();

            Assert.True(responseMessage.Contains("error"));
        }
    }
}
