using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_Session_3.Binding
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Age { get; set; }

        public void Myfun01()
        {
            Console.WriteLine("I am Employee");
        }

        public void virtual Myfun02()
        {
            Console.WriteLine($" Id = {Id} , Name = {Name}, Age = {Age} ,");
        }

        public class FullTimeEmployee : Employee 
        {
            public decimal Salary { get; set; }

            public new void Myfun01()
            {
                Console.WriteLine("I am Full Time Employee");
            }
        }
    }
}
