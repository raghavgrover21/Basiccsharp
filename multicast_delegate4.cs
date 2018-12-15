using System;
using System.Collections.Generic;
using System.Collections;
    namespace New_folder__2_
    
    //multicast delegate 3rd
   /*
   why multicast delegate?
   because they make observer design pattern very simple
   if one is using delegates then we are using observer design pattern indirectly
    */
 {   
     public delegate void Sample1(out int Integer);                              
        
        public class Program
        {     
            public static void Main()
            {           
                Sample1 del1= new Sample1(SampleMethod1);
                del1+=SampleMethod2;                    
                int valueofdel=-1;
                del1(out valueofdel);  
                
                 Console.WriteLine(valueofdel); //2 gets printed since last delegate that calls the function is samplemethod2
            }
        
            public static void SampleMethod1(out int number)
            {
                number=1;
            }

            public static void SampleMethod2(out int number)
            {
                number=2;
            }
            
    } 
}
 

