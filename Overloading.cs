using System;

namespace New_folder__2_
{
    public class Program    //this program does not compile
    {
        public static void Main(string[] args) // we can perform overloading using by having differnt no of parameter and differnt type
                                               // of parameter /
                                               //where as in function overloading it depends on return type as well
        {   
          Program ob1 = new Program();
          string res = ob1.check1(10,20);
          int x = ob1.check1(10,20);
          Console.WriteLine("the string is{0}",res);
          Console.WriteLine("the no  is{0}",x);
        }

        public int check1(int a ,int b) //overloading cannot be done on method return type 
        {
            return 0;
        }
    
        public string check1(int a , int b)
        {
            string x="raghav";
            return x;
        }
    }

   

}



