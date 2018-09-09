using System;
using System.Collections.Generic;
    namespace New_folder__2_
                                           
 {                                         
     public delegate void del_fun1(string str);
    public class Program
    {   
        public static void Main(string[] args)
        {                                   
           del_fun1 ob1 = new del_fun1(fun1);       //creating the object of the delegate just like a class (delegate is type safe function pointer)
                                                    //type safe- same signature as that of the function it is going to point to
           ob1("welcome to C#");
        }
        public static void fun1(string str)
        {
            Console.WriteLine(str);
        }
    
    }

}


