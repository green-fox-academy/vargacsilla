using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace CalorieApp.IntegrationTestsWRONG
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

        public async Task ShouldReturnOk()
        {
            var response = await Client.GetAsync("drax");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
