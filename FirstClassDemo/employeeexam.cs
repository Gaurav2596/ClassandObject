using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    public class employeeexam
    {
        private int id;
        private string name;
        private double bs, hra, ta, pf, gs;

        public employeeexam(int id, string name, double bs)
        {
            this.id = id; 
            this.name = name;
            this.bs = bs;
        }   
        
        public void Calculate()
        {
            hra = bs * 40 / 100;
            ta = bs * 20 / 100;
            pf = bs * 12 / 100;
            gs = bs + hra + ta - pf;   
        }
        public override string ToString()
        {
            return $"Employee name is {name},id is {id},basic salary is {bs},gross salary is {gs}";
        }
    }
}

        
    
	

	
    
	

