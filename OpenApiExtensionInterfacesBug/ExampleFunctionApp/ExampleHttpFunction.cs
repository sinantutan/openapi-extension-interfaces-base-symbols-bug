using System.IO;
using System.Net;
using System.Threading.Tasks;
using ExampleFunctionApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ExampleFunctionApp;

public static class ExampleHttpFunction
{
    [FunctionName(nameof(ExampleFunction))]
    [OpenApiOperation(nameof(ExampleFunction), Summary = "Example Function for reproducing bug.")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, bodyType: typeof(AccessBook), contentType:"application/json", Example = typeof(OpenApiPersonWithAccessResponseExample))]
    public static async Task<IActionResult> ExampleFunction(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        string name = req.Query["name"];

        string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        dynamic data = JsonConvert.DeserializeObject(requestBody);
        name = name ?? data?.name;

        return name != null
            ? (ActionResult)new OkObjectResult($"Hello, {name}")
            : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        
    }
}