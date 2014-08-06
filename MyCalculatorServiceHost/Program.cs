using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using SelfHosting;
using System.ServiceModel.Description;

namespace MyCalculatorServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost/MyService/SimpleCalculator");
            //Create ServiceHost
            ServiceHost host = new ServiceHost(typeof(MyCalculatorService), httpUrl);
            //Add a service endpoint
            host.AddServiceEndpoint(typeof(IMyCalculatorService), new WSHttpBinding(), "");
            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            host.Description.Behaviors.Add(smb);
            //Start the Service
            host.Open();

            Console.WriteLine("Service is host at " + DateTime.Now.ToString());
            Console.WriteLine("Host is running... Press <Enter> key to stop");
            Console.ReadLine();

        }
    }
}
