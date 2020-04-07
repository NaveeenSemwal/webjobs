using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWebJob
{
    public class Functions
    {
        public static void ProcessQueueMessage([QueueTrigger("empqueue")] string message, ILogger logger)
        {
            logger.LogInformation(message);
        }
    }
}
