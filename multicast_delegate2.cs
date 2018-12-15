using System;
using System.Collections.Generic;
using System.Collections;
    namespace New_folder__2_
    
    //multicast delegate 2nd
   
 {   
     public delegate void Sample1();                              
        
        public class Program
        {     
            public static void Main()
            {           
                Sample1 del1= new Sample1(SampleMethod1);
                del1+=SampleMethod2;    //invokes both samplemethod1 and samplemethod2
                
                 del1();
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
 

