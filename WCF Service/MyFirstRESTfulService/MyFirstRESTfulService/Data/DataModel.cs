﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;


namespace MyFirstRESTfulService
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmpId { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Lname { get; set; }
        [DataMember ]
        public DateTime JoinDate { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public string Designation { get; set; }
    }


    public partial class EmployeeData
    {
        private static readonly EmployeeData _instance = new EmployeeData();

        private EmployeeData() { }

        public static EmployeeData Instance
        {
            get
            {
                return _instance;
            }
        }


        private List<Employee> empList = new List<Employee>()
        {
            new Employee() { EmpId  = 1, Fname = "Sam", Lname = "kumar", JoinDate=new DateTime(2010,7, 21), Age=30,Salary=10000,Designation="Software Engineer"},
            new Employee() { EmpId = 2, Fname = "Ram", Lname = "kumar", JoinDate=new DateTime(2009,6,8), Age=35,Salary=10000,Designation="Senior Software Engineer"},    
            new Employee() { EmpId = 3, Fname = "Sasi", Lname = "M", JoinDate=new DateTime(2008,3,5), Age=39,Salary=10000,Designation="Projet Manager"},  
            new Employee() { EmpId = 4, Fname = "Praveen", Lname = "KR", JoinDate=new DateTime(2010, 5,1), Age=56,Salary=10000,Designation="Projet Manager"},
            new Employee() { EmpId = 5, Fname = "Sathish", Lname = "V", JoinDate = new DateTime(2006,12,15), Age=72,Salary=10000,Designation="Senior Software Engineer"},  
            new Employee() { EmpId = 6, Fname = "Rosh", Lname = "A", JoinDate=new DateTime(2009,2,2), Age=25,Salary=10000,Designation="Software Engineer"}
        };

        public List<Employee> EmployeeList
        {
            get
            {
                return empList;
            }
        }


        public void Update(Employee updEmployee)
        {
            Employee existing = empList.Find(p => p.EmpId == updEmployee.EmpId);

            if (existing == null)
                throw new KeyNotFoundException("Specified Employee cannot be found");

            existing.Fname = updEmployee.Fname;
            existing.Lname = updEmployee.Lname;
            existing.Age = updEmployee.Age;
        }

        public void Delete(int empid)
        {
            Employee existing = empList.Find(p => p.EmpId == empid);
            empList.Remove(existing);
        }
        public void Add(Employee newEmployee)
        {
            empList.Add(new Employee
            {
                EmpId = newEmployee.EmpId,
                Fname = newEmployee.Fname,
                Lname = newEmployee.Lname,
                Age = newEmployee.Age,
                JoinDate = DateTime.Now,
                Designation = newEmployee.Designation,
                Salary = newEmployee.Salary
            });
        }
    }
}
