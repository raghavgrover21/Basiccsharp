using System;
using System.Collections.Generic;
    namespace New_folder__2_
{
    public abstract class Ab1           //abstract classes cannot be sealed 
    {
        public abstract void print1();
    }

    public class Program : Ab1
    {   
        public override void print1()
        {
            Console.WriteLine("inside Abstract function implementation"); 
        }
        public static void Main(string[] args)
        {                                   
           Ab1 ob1 = new Program();
           ob1.print1();
        }
    }
   
}


