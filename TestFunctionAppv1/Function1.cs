using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace TestFunctionAppv1
{
    public class TestFunction1
    {
        private readonly ILogger<TestFunction1> _logger;

        public TestFunction1(ILogger<TestFunction1> logger)
        {
            _logger = logger;
        }

        [Function("TestFunction1")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request test.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
