using System;

namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        {   
          Employee ob1 = new part();
          ob1.print();

          Employee ob2 = new permanent();
          ob2.print();   

        }
    
    }

    public class Employee
    {
        string fname = "FN";
        string lname = "LN";

        public void print()
        {
            Console.WriteLine("{0}   {1}",fname,lname);
        }
    }
     class part : Employee
    {
        public  new void print()
        {}
    }
    class permanent : Employee
    {
        public new void print()
        {}
    }
   

}



