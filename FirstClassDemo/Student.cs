using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    public enum Streams  {CS,IT,Electrical,Electronics,Mechanical,Civil}
    public class Student
    {
        private int id;
        private string name;
        private double percentage;
        private Streams stream;

        public Student(int id,string name,double percentage,Streams stream)
        {
            this.id = id;
            this.name = name;
            this.percentage = percentage;
            this.stream = stream;
            
        }
        public override String ToString()
        {
            return $"Name is {name} :: Id is {id} :: Percentage is {percentage} :: Stream is {stream}";
        }
    }
}
