using ServerInferfaceWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            // we need to set the config: by right clicking app.config and edit wcf config

            //creating the channel
            ChannelFactory<IWCFArtistService> channelFactory = new
                                        ChannelFactory<IWCFArtistService>("ArtistServiceEndPoint");  // optional to give the endpoint name

            //creating the proxy
            IWCFArtistService proxy = channelFactory.CreateChannel();
            List<string> artists = proxy.ListArtists();
            foreach (string a in artists)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }
    }
}
