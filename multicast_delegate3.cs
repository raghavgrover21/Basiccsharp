using System;
using System.Collections.Generic;
using System.Collections;
    namespace New_folder__2_
    
    //multicast delegate
   
 {   
     public delegate int Sample1();                              
        
        public class Program
        {     
            public static void Main()
            {           
                Sample1 del1= new Sample1(SampleMethod1);
                del1+=SampleMethod2;                    
                 int x= del1(); // the value returned by the last delegate function
                                //that is called gets assigned to x i.e 2 in the given case
                 Console.WriteLine(x);
            }
        
            public static int SampleMethod1()
            {
                return 1;
            }

            public static int SampleMethod2()
            {
                return 2;
            }
            
    } 
}
 

