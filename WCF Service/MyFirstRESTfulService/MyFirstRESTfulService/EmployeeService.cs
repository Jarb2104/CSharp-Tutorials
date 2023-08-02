using System.Collections.Generic ;
using System.Linq ;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
using System.ServiceModel.Activation;

namespace MyFirstRESTfulService
{
    [AspNetCompatibilityRequirements(RequirementsMode= AspNetCompatibilityRequirementsMode.Allowed )]
   public  class EmployeeService: IEmployeeService 
    {
        
       public List <Employee> GetAllEmployeeDetails()
        {
            return EmployeeData.Instance.EmployeeList;
        }
      
        public Employee GetEmployee(int id)
        {
            IEnumerable<Employee> empList = EmployeeData.Instance.EmployeeList.Where(x => x.EmpId == id);

            if (empList != null)
                return empList.First<Employee>();
            else
                return null;
        }

     
       public void AddEmployee(Employee newEmp)
       {
           EmployeeData.Instance.Add(newEmp);
       }

       
        public void UpdateEmployee( Employee newEmp)
        {
            EmployeeData.Instance.Update(newEmp);
        }

      
         public void DeleteEmployee(string empId)
        {
            EmployeeData.Instance.Delete(System.Convert .ToInt32 (empId));
        }
    }
}
