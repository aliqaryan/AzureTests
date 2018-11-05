using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace SbTriggerFunction
{
    public static class SbTriggerFunc
    {
        [FunctionName("SbTriggerFunc")]
        public static void Run([ServiceBusTrigger("sb-topic", "sub-1", Connection = "MyConnection")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
