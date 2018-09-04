using System;
using System.Collections.Generic;
    namespace New_folder__2_
{
    interface I1
    {
        void print();
    }
    interface I2
    {
        void print();
    }
    public class Program : I1,I2
    {
        public static void Main(string[] args)
        
        {                                   
            // Program ob1= new Program();
            // ((I1)ob1).print();          //typecasting the object into the reference type of interface 1 I1
            // ((I2)ob1).print();          //typecasting the object into the reference type of interface 2 I2
            //or

            I1 ob1 = new Program(); 
            I2 ob2 = new Program();
            ob1.print();
            ob2.print();
        }
   
    // public void print ()    //when you are explicitly implementing an interface you should not use access modifier
        void I1.print()             //specify which interface you would like to use for d given function
    {
        Console.WriteLine("function of I1");
    }
        void I2.print()             //specify which interface you would like to use for d given function
    {
        Console.WriteLine("function of I2");
    }


    }
}


