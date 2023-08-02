using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace MyFirstRESTfulServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ////Create a URI to serve as the base address
                //Uri httpUrl = new Uri("http://localhost:8090/MyService/EmployeeService");
                ////Create ServiceHost
                //ServiceHost host
                //= new ServiceHost(typeof(MyFirstRESTfulService.EmployeeService), httpUrl);
                ////Add a service endpoint with RESTful service endpoint
                //host.AddServiceEndpoint(typeof(MyFirstRESTfulService.IEmployeeService)
                //, new WebHttpBinding(), "");
                ////Enable metadata exchange
                //ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                //smb.HttpGetEnabled = true;
                //host.Description.Behaviors.Add(smb);
                ////Start the Service
                //host.Open();

                Uri httpUrl = new Uri("http://localhost:8090/MyService/EmployeeService");
                WebServiceHost host = new WebServiceHost(typeof(MyFirstRESTfulService.EmployeeService), httpUrl);
                host.Open();
            
                foreach (ServiceEndpoint se in host.Description.Endpoints)
                        Console.WriteLine("Service is host with endpoint " + se.Address);
                //Console.WriteLine("ASP.Net : " + ServiceHostingEnvironment.AspNetCompatibilityEnabled);
                Console.WriteLine("Host is running... Press <Enter> key to stop");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
