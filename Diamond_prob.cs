using System;
using System.Collections.Generic;
    namespace New_folder__2_
                                            //this code is just to undestand the problem
 {                                               //  A
                                                //  / \  
                                            //     B   C
                                            //      \ /
                                            //       D            
    public class Program                //diamond problem for interitance
    {   
        public static void Main(string[] args)
        {                                   
            
        }
    }
    public class A
    {
        public virtual void print1()        
           { 
               Console.WriteLene("inside of A");
           }
        
    }
    class B : A 
    {
        public override void print1()
        { 
               Console.WriteLene("inside of B");
        }
    }

    class C : A 
    {
        public override void print1()
        { 
               Console.WriteLene("inside of C");
        }
    }

    class D : B,C // this very line will give error because c# does not support multiple inheritence
                  //  now if multiple inheritance was allowed - it would lead to ambiguity as when we try to
                  //override the print1() then compiler would get confused which class method it is supposed to override
    {

    }
}


