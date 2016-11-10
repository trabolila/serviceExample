using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TestService.Contracts
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        string TestServiceCall();

        [OperationContract]
        string TestServiceCallWithParam(string aString);
    }
}
