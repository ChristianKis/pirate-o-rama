using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace PirateORama.WebApi.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:1234"))
            {
                Console.WriteLine("Host started...");
                Console.ReadLine();
            }
        }
    }
}
