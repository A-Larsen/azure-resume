using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace My.Functions
{
    public static class HttpExample
    {
        [FunctionName("HttpExample")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            [CosmosDB(databaseName: "my-database", collectionName: "my-container",
             Id = "1", PartitionKey = "1",
             ConnectionStringSetting = "CosmosDbConnectionString"
             )] Counter counter,
            [CosmosDB(databaseName: "my-database", collectionName: "my-container",
             Id = "1", PartitionKey = "1",
             ConnectionStringSetting = "CosmosDbConnectionString"
             )] out Counter updatedCounter,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            updatedCounter = counter;
            updatedCounter.Count += 1;
            var jsonToReturn = JsonConvert.SerializeObject(counter);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent(jsonToReturn, Encoding.UTF8, "application/json")
            };
        }
    }
}