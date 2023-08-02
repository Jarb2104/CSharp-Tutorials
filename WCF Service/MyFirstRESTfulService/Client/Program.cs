using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Web;
using MyFirstRESTfulService;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            WebChannelFactory<IEmployeeService > cf =
               new WebChannelFactory<IEmployeeService>(
                   new Uri("http://localhost:8090/MyService/EmployeeService"));
            IEmployeeService client = cf.CreateChannel();
            var d = client.GetEmployee(1);
            //Load all the Employee from the server and display
           foreach (Employee e in   client.GetAllEmployeeDetails() )
           {
           Console.WriteLine(string.Format("EmpID:{0}, Name:{1} {2}",e.EmpId ,e.Fname ,e.Lname ));
           }

            //Add new user
           client.AddEmployee(new Employee() { EmpId = 11, Fname = "John", Lname = "J", JoinDate = new DateTime(2010, 7, 24), Age = 34, Salary = 10000, Designation = "Software Engineer" });
        
            Console.WriteLine("******************After adding new user ****************");

        //Load all the Employee from the server and display
         foreach (Employee e in   client.GetAllEmployeeDetails() )
           {
           Console.WriteLine(string.Format("EmpID:{0}, Name:{1} {2}",e.EmpId ,e.Fname ,e.Lname ));
           }
            Console.ReadLine();
        }
   
        }

}
