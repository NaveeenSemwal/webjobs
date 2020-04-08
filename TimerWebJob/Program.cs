using Microsoft.Extensions.Hosting;
using System;

namespace TimerWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new HostBuilder();
            builder.ConfigureWebJobs(b =>
            {
                b.AddTimers();
                b.AddAzureStorageCoreServices();
            });
             
            var host = builder.Build();
            using (host)
            {
                host.Run();
            }
        }
    }
}
