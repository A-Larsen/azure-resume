using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;

namespace tests
{
    public class TestCounter
    {

        [Fact]
        public async void Http_trigger_should_return_known_string()
        {
            var counter = new My.Functions.Counter();
            counter.Id = "index";
            counter.Count = 2;
            Assert.Equal(counter.Count, 2);
        }
    }
}
