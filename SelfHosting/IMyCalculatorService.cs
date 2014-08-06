using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SelfHosting
{
    [ServiceContract()]
    public interface IMyCalculatorService
    {
        [OperationContract()]
        int Add(int num1, int num2);
    }


}
