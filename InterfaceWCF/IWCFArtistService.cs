using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace ServerInferfaceWCF
{
   [ServiceContract]
    public interface IWCFArtistService
    {
        [OperationContract]
        List<string> ListArtists();
    }
}
