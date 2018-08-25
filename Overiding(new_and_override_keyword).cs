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

        public virtual void  print()
        {
            Console.WriteLine("{0}   {1}",fname,lname);
        }
    }
     class part : Employee
    {
        public override void print()
        { Console.WriteLine("{0}   {1}");} 
    }
    class permanent : Employee
    {
        public override void print()
        { Console.WriteLine("{2}   {3}");}
    }
   

}



