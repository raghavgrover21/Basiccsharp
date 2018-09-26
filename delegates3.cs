using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate bool promote(Employee emp);
    class Program
    {
        
        static void Main(string[] args)
        {
            //print1 ob1 = new print1(print);
            //ob1("welcome"); 
            List<Employee> ob1 = new List<Employee>();
            ob1.Add(new Employee() { id = 1, name = "A", salary = 100, experience = 5 });
            ob1.Add(new Employee() { id = 2, name = "B", salary = 200, experience = 3 });
            ob1.Add(new Employee() { id = 3, name = "C", salary = 300, experience = 2 });
            ob1.Add(new Employee() { id = 4, name = "D", salary = 400, experience = 8 });
            ob1.Add(new Employee() { id = 5, name = "E", salary = 500, experience = 9 });
            Employee ob2 = new Employee();
            promote objct = new promote(ispromotable);
            ob2.promoteEmp(ob1,objct);

        }
        public static bool ispromotable(Employee emp)
        {
            if (emp.experience >= 5)
                return true;

            else
                return false;

        }

    }
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public void promoteEmp(List<Employee> emp,promote eligible )
        {
            foreach(Employee Emp in emp)
            {
                if(eligible(Emp)!=true)
                {
                    Console.WriteLine("promoted"+Emp.name);
                }

            }
        }

    }
}
