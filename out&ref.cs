using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {
            int y=1;
            int z=0;
          Program ob1 = new Program();

            Console.WriteLine("without ref{0}",y);
            ob1.Fun1(ref y);
            Console.WriteLine("with ref{0}",y);
            
          
            Console.WriteLine("before out keyword{0}",z);
            ob1.Outpar(out z);
            Console.WriteLine("after out keyword{0}",z);    
        }
        void Fun1(ref int x)
        {
            x=100;
        }
        void Outpar(out int x)
        {
            x=100;
        }
    }
}
