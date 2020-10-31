using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TcpBinding.Contracts
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        string[] GetStrings();
    }
}
