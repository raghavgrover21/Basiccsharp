using System;
using System.Collections.Generic;
using System.Collections;
    namespace New_folder__2_
    
    //multicast delegate
   
 {   
     public delegate void Sample1();                              
        
        public class Program
        {     
            public static void Main()
            {           
                Sample1 del1,del2,del3,del4;
                
                 del1 = new Sample1(SampleMethod1);
                del2 = new Sample1(SampleMethod2);
                del3 = new Sample1(SampleMethod3);
                // del4= del1+del2+del3;
                del4= del1+del2+del3-del2;// only samplemethod1 and samplemethod3 gets invoked
                del4();
            }
        
            public static void SampleMethod1()
            {
                Console.WriteLine("1st delegate");
            }

            public static void SampleMethod2()
            {
                Console.WriteLine("2nd delegate");
            }
            public static void SampleMethod3()
            {
                Console.WriteLine("3rd delegate");
            }   
    } 
}
 

