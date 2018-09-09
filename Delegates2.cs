using System;
using System.Collections.Generic;
    namespace New_folder__2_
    //why do we need delegates                             
 {                                         
    
    public class Program
    {   //this code is not that good because
        //if we want to promote employees on the basis of salary then we would have to change the entire code
        // so we use delegates
        //SEE Delegates3.cs and compare code with Delegates2.cs
        public static void Main()
        {
            List<Employee> ob1 = new List<Employee>();
            Employee ob2 = new Employee(){ ID=1,Name="A",Salary=20000,Exp=7 };
            Employee ob3 = new Employee(){ ID=2,Name="B",Salary=200000,Exp=2 };
            Employee ob4 = new Employee(){ ID=3,Name="C",Salary=200000,Exp=6 };
            //or
            //ob1.Add(new Employee{ID=4,Name="emp_name",Salary=12345,exp=9}); <- this seems more precise or clean code
            ob1.Add(ob2);
            ob1.Add(ob3);
            ob1.Add(ob4);
            Employee res = new Employee();
            res.promote(ob1);

        }
        
    
    }
    public class Employee
    {
        public int ID{get; set;}
        public string Name{get; set;}
        public int Salary{get;set;}
        public int Exp{get;set;}

        public void promote(List<Employee> emp)             //this function gets changed for everytime we want to decide
        {                                                   //on what basis do we want to promote the employee
            foreach(Employee Emp in emp)
            {
                if(Emp.Exp >= 5)
                Console.WriteLine("You will be promoted  {0}",Emp.Name);
            }
        }
    }

}


