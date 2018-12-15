using System;
using System.Collections.Generic;
    namespace New_folder__2_
       //GENERIC FUNCTION
 {                                         
    
    public class Program
    {     
        public static void Main()
        {
            Program ob1 = new Program();
            ob1.IsEqual<string>("AB","AB");
            ob1.IsEqual<int>(10,20);

        }
        
        public void IsEqual<T>(T value1 ,T value2)
        {
            bool check= value1.Equals(value2);
                
                if(check==true)
                Console.WriteLine("Yes true");

                else 
                Console.WriteLine("Not true");
        }
    }
}



