using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace CsFromScratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohoyhoy world");
            Console.ReadKey();
            //CreateWebHostBuilder(args).Build().Run();
            //Debug.WriteLine("Ohoyhoy world");
            //Console.WriteLine(args[0]);
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
        }
    }
}
