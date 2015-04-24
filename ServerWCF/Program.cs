using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerWCF
{
    class Program
    {
        // this will host my service

        // we need to set the config: by right clicking app.config and edit wcf config
        static void Main(string[] args)
        {
            using(ServiceHost host = new ServiceHost(typeof(WCFArtistService)))
            {
                host.Open();
                Console.WriteLine("Serveur wcf is open");
                Console.WriteLine("Press Enter to close server");
                Console.ReadLine();
            }
        }
    }
}
