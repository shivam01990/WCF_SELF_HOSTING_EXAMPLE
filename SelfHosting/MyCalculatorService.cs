using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelfHosting
{
   public class MyCalculatorService : IMyCalculatorService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
