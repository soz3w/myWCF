using ServerInferfaceWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerWCF
{
    class WCFArtistService : IWCFArtistService
    {

        public List<string> ListArtists()
        {
            Console.WriteLine("ListArtist() has been called by a client");

            List<string> artistList = new List<string>();
           try 
            {	        
		            using(ModelData Db = new ModelData())
	                    {
                            var artists = Db.Artists.Select(a => a.Name);

                            //var artists = from a in Db.Artists
                            //              select a.Name;

                            artistList = artists.ToList();
	                    }
            }
	        catch
	        {
		
	        }
           return artistList;

        }
    }
}
