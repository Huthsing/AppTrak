using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AppTrack.Resource.Interfaces
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        Task<bool> VerifyLogin();
    }
}
