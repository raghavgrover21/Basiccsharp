using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           int [] abc = new int[3];
           abc[0]=10;
           abc[1]=20;
           abc[2]=30;
        //    abc[3]=40;

           for(int i=0;i<abc.Length;i++)
            {
                Console.WriteLine("value at {0}",abc[i]);
            }     
        


        }
    }
}
