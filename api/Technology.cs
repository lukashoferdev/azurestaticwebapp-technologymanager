using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace api
{
    public static class Technology
    {
        [FunctionName("Technology")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger Technology function processed a request.");

            string responseMessage = "This Azure Static Web App shows the functionality of a static web app and the use of a Azure func to get some data. This message was delivered by the Azure Technology Function";
            
            return new OkObjectResult(responseMessage);
        }
    }
}
