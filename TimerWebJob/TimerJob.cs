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
    class TimerJob
    {
        [FunctionName("TimerTrigger")]
        public static void Run([TimerTrigger("* */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
             log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
