using System;

namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        {   
          
           PartTimer ob1 = new PartTimer(10,"a","b");
           ob1.pdetails();
        
        PermanentEmp ob2 = new PermanentEmp(100,"Fname","Lname");
           ob2.pdetails();
        }
    
    }
    public class Employee       //base class
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

    class PartTimer : Employee      //child class1
    {
        int salary;
        public PartTimer(int salary,string Fname, string Lname):base(Fname,Lname)
        {    //this is how we pass the value from child to parent by using base keyword as give above statement
            this.salary=salary;
        }
        
        public void pdetails()
        {
            Console.WriteLine("Part time employee name is {0} {1} and daily salary is {2}",Fname,Lname,salary);
        }
    }


    class PermanentEmp : Employee   //child class2 
    {
        int salary;
        public PermanentEmp(int salary,string Fname, string Lname): base(Fname,Lname)
            {
               
                this.salary=salary;
            }
        public void pdetails() 
            {
                Console.WriteLine("Permanent employee name is {0} {1} and monthly salary is {2} ",Fname,Lname,salary);
            }   

    }

}



