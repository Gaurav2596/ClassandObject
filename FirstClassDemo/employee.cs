

using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace FirstClassDemo
{
    public class Employee
    {
        private int empid;
        private string empname, city;
        private double salary;

        public Employee(int empid, string empname, double salary, string city = "Pune")
        {
            this.empid = empid;
            this.empname = empname;
            this.city = city;
            this.salary = salary;
        }


        public string Display()
            {
                return $"Name is {empname}:: Id is {empid}::Salary is {salary}:: City is {city}";
            }
        
    }

}
