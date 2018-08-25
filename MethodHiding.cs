using System;

namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        {   
          
           PartTimer ob1 = new PartTimer(10,"a","b");
           ob1.Print();
        
        PermanentEmp ob2 = new PermanentEmp(100,"Fname","Lname");
           ob2.Print();
        }
    
    }
    public class Employee
    {
        protected string Fname,Lname;
    
        public Employee(string Fname , string Lname)
        {
            this.Fname= Fname;
            this.Lname= Lname;
        }

        public void Print() 
        {
         Console.WriteLine("name is {0}  {1}",Fname,Lname);
        }
    }

    class PartTimer : Employee
    {
        int salary;
        public PartTimer(int salary,string Fname, string Lname):base(Fname,Lname)
        {    
            this.salary=salary;
        }
        
        public void Print()
        {
            base.Print();
            // Console.WriteLine("Part time employee name is {0} {1} and daily salary is {2}",Fname,Lname,salary); //this method hides the parent class
                                                                                                                //function print but we can use base.
                                                                                                                //method() to call the parent class method
       
       
        }
    }


    class PermanentEmp : Employee
    {
        int salary;
        public PermanentEmp(int salary,string Fname, string Lname): base(Fname,Lname)
            {
               
                this.salary=salary;
            }
        public void print() 
            {
                Console.WriteLine("Permanent employee name is {0} {1} and monthly salary is {2} ",Fname,Lname,salary);
            }   

    }

}



