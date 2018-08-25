using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
          int no=int.Parse(Console.ReadLine());

            switch (no)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("the number is{0}",no);
                    break;

                default:
                    Console.WriteLine("not valid");
                
                break;
           
            }   


        }
    }
}
