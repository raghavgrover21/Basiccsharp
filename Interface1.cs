using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Print ob1 = new Print();
            ob1.print();
             Console.ReadKey();
        }
    }
    public interface IPrint
    {
         void print();
    }
     class Print : IPrint
    {
        public void print()
        {
            Console.WriteLine("interface is implemented");
        }
    }
}