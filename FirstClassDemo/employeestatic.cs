using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    public enum Dept {HR=101,Admin,Sales,Devlopment,testing};

        
    public class Employeestatic
    {
        protected string name;
        protected double salary, hra, ta, da, pf, totalsalary;
        protected int empid;
        private static int count;
        private Dept dept;

        public Employeestatic(string name,double salary,Dept dept)
        {
            count++;
            this.empid=count;
            this.name = name;
            this.salary = salary;  
            this.dept = dept;
        }

        public virtual   void CalculateSalary()
        {
            hra = salary * 40 / 100;
            ta = salary * 20 / 100;
            da = salary * 15 / 100;
            pf = salary * 12 / 100;
            totalsalary = salary + hra + ta - pf;
        }

        public override string ToString()
        {
            return $"Name is {name} empid is {empid} Salary is {salary} and Gross salary is {totalsalary} Dept {dept}";
        }
        public static int Getcount() 
        { 
            return count;
        }
    }
    public class SalesManager:Employeestatic
    {
        private double comm;

        public SalesManager(string name,double salary,double comm,Dept dept):base(name, salary,dept) 
        {
            this.comm = comm;
        }
        public override void CalculateSalary()
        {
            hra = salary * 40 / 100;
            ta = salary * 20 / 100;
            da = salary * 15 / 100;
            pf = salary * 12 / 100;
            totalsalary = salary + hra + ta + da + comm - pf;
        }
        public override string ToString()
        {
            return $"Name is {name} empid is {empid} Salary is {salary} and Gross salary is {totalsalary}";
        }


    }
    public class Ceo:Employeestatic
    {
        private double profit;

        public Ceo (string name,double salary,double profit, Dept dept):base(name, salary,dept)
        {
            this.profit = profit;
        }
        public override void CalculateSalary()
        {

            hra = salary * 40 / 100;
            ta = salary * 20 / 100;
            da = salary * 15 / 100;
            pf = salary * 12 / 100;
            totalsalary = salary + hra + ta + da - pf + profit;
        }
        public override string ToString()
        {
            return $"Name is {name} empid is {empid} Salary is {salary} and Gross salary is {totalsalary}";
        }
    }

 }

