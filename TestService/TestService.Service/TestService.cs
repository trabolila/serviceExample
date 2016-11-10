using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestService.Contracts;
using System.ServiceModel;

namespace TestService.Service
{

    public class TestService : ITestService
    {
        public string TestServiceCall()
        {
            return "Service call hit";
        }

        public string TestServiceCallWithParam(string aString)
        {
            return "Service call hit with param : " + aString;
        }
    }
}
