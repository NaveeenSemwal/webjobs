using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EmployeeWebJob
{
    public class Functions
    {
        /// <summary>
        /// This will be triggered whenever message added to empqueue
        /// </summary>
        /// <param name="message"></param>
        /// <param name="logger"></param>
        [FunctionName("QueueTrigger")]
        public static void ProcessQueueMessage([QueueTrigger("empqueue")] string message, ILogger logger)
        {
            logger.LogInformation(message);
        }



        /// <summary>
        /// writes a log when a blob is added or updated in the webjob-blob container.
        /// </summary>
        /// <param name="myBlob"></param>
        /// <param name="name">This should be string with .txt extension</param>
        /// <param name="log"></param>
        [FunctionName("BlobTrigger")]
        public static void Run([BlobTrigger("webjob-blob/{name}.txt")] Stream myBlob, string name, ILogger log)
        {
            // From here you can read the stream and process that.
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }


    }
}
