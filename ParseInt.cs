using System;

namespace New_folder__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string str = "1";
            int result=0; 
            bool check = int.TryParse(str,out result );

            if(check)
            {
                Console.WriteLine("Yes completed{0}",result);
            }
            else 
            {
                Console.WriteLine("enter a valid number");
            }

        }
    }
}
