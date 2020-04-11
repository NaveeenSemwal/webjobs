using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimerWebJob
{
    /// <summary>
    /// https://energizedanalytics.com/en/azure-web-jobs-with-net-core/
    /// </summary>
    public class TimerJob
    {
        //Make sure the class and method are public to be recognized by the WebJob SDK.
        [FunctionName("TimerTrigger")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
