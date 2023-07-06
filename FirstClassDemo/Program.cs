
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    internal class Program
    {
        static void Main(string[] args) {

            //Product prod1 = new Product();
            //prod1.Code = 101;
            //prod1.Name = "Nokia";
            //prod1.Price = 10000;

            //Console.WriteLine($"Product code is {prod1.Code}:Product name is {prod1.Name}:Price is {prod1.Price}");

            //Product prod2 = new Product() { Code = 102, Price = 15000, Name = "Samsung" };
            //Console.WriteLine($"Product code is {prod2.Code}:Product name is {prod2.Name}:Price is {prod2.Price}");

            //Employee emp = new Employee(101, "Gaurav", 15000);

            //Employee emp1 = new Employee(102, "Yash", 20000, "Mumbai");

            //Employee emp2 = new Employee(empid: 103, empname: "Manish", salary: 25000, city: "Nashik");

            //Console.WriteLine(emp.Display());
            //Console.WriteLine(emp1.Display());
            //Console.WriteLine(emp2.Display());



            //employeestatic emp = new employeestatic("Gaurav", 20000);
            //employeestatic emp1 = new employeestatic("Ram", 30000);

            //emp.CalculateSalary();
            //emp1.CalculateSalary();
            //Console.WriteLine(emp.Print());
            //Console.WriteLine(emp1.Print());

            //Console.WriteLine(employeestatic.Getcount());


            //Subtraction
            //Methodoverloading m1 = new Methodoverloading();
            //int res = m1.Subtraction(20, 10);
            //Console.WriteLine(res);
            //double res1= m1.Subtraction(36.8, 19.5);
            //Console.WriteLine(res1);


            ////Multiplication

            //int dis = m1.Multiplication(15, 5);
            //Console.WriteLine(dis);

            //double dis2 = m1.Multiplication(12.5, 20.5);
            //Console.WriteLine(dis2);

            //Ceo c1 = new Ceo("yash", 50000, 50000);
            //c1.CalculateSalary();
            //Console.WriteLine(c1);

            //Employeestatic employee = new Employeestatic("Ganesh",30000);
            //employee.CalculateSalary();
            //Console.WriteLine(employee);

            //SalesManager salemanager = new SalesManager("Gaurav", 40000, 10000);
            //salemanager.CalculateSalary();
            //Console.WriteLine(salemanager);

            //Circle c1 = new Circle(3);
            //c1.CalculateArea();
            //Console.WriteLine(c1);

            //Rectangle r1 = new Rectangle(4,7);
            //r1.CalculateArea();
            //Console.WriteLine(r1);

            //employeeexam e1 = new employeeexam(101,"Gaurav",40000);
            //e1.Calculate();
            //Console.WriteLine(e1);

            //productexam p1 = new productexam(5000,10);
            //p1.Display();
            //Console.WriteLine(p1);



            //string str1 = "Hello";
            //Console.WriteLine(str1);
            //Console.WriteLine(str1.GetHashCode());
            //str1 = "Hello to all";
            //Console.WriteLine(str1);
            //Console.WriteLine(str1.GetHashCode());
            //Console.WriteLine(str1.Length);
            //string str2 = " Good evening";

            //string str3 = string.Concat(str1, str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str3.IndexOf("e"));
            //Console.WriteLine(str3.LastIndexOf("e"));

            //string str4 = str3.Substring(0, 5);
            //Console.WriteLine(str4);

            //Console.WriteLine(string.IsNullOrEmpty(str3));
            //string str5 = null;
            //Console.WriteLine(string.IsNullOrEmpty(str5));

            //Console.WriteLine("Enter a name");
            //string s = Console.ReadLine();
            //Console.WriteLine(string.IsNullOrEmpty(s));

            //char[] ch = str1.ToCharArray();
            //for (int i = 0;i<ch.Length; i++)
            //{
            //    Console.WriteLine(ch[i]);
            //}

            //StringBuilder sb = new StringBuilder("Hello to all");
            //StringBuilder sb2 = new StringBuilder(20);
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());


            //sb.Append(" Good Morning");
            //Console.WriteLine(sb);
            //Console.WriteLine(sb.GetHashCode());
            //sb.Insert(5, " Namaste");
            //Console.WriteLine(sb);
            //sb.Remove(5, 8);
            //Console.WriteLine(sb);

            //sb.Replace("to", "To");
            //Console.WriteLine(sb);

            //StringBuilder sb3 = new StringBuilder("Your Amount is ");
            //sb3.AppendFormat("{0:C}", 25000);
            //Console.WriteLine(sb3);

            //Employeestatic emp = new Employeestatic("gaurav",30000,Dept.Admin);
            //emp.CalculateSalary();
            //Console.WriteLine(emp);

            //Employeestatic emp1 = new Employeestatic("Ram", 35000, Dept.testing);
            //emp1.CalculateSalary();
            //Console.WriteLine(emp1);

            Student s1 = new Student(5,"Gaurav",70,Streams.IT);
            s1.ToString();
            Console.WriteLine(s1);

        }
          
          
         


    }
}
