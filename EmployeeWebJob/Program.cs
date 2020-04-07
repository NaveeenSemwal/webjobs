using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EmployeeWebJob
{
    class Program
    {
        /// <summary>
        /// https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-how-to
        /// https://docs.microsoft.com/en-us/azure/app-service/webjobs-dotnet-deploy-vs
        /// https://docs.microsoft.com/en-us/azure/app-service/webjobs-create
        //https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-get-started
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //https://docs.microsoft.com/en-us/azure/app-service/webjobs-sdk-get-started : GOOD

            //https://briancaos.wordpress.com/2019/03/29/read-from-azure-queue-with-azure-webjobs-3-0-and-net-core/
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddAzureStorageCoreServices();
                b.AddAzureStorage();
            });
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}

