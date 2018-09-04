using System;
using System.Collections.Generic;
    namespace New_folder__2_
                                           
 {                                         

    public class Program
    {   
        public static void Main(string[] args)
        {                                   
          AB ob1 = new AB();
          ob1.A_print();
          ob1.B_print();  
        }
    }

    public interface I1
    { void A_print();}

    class A : I1
    {
        public void A_print()
        {Console.WriteLine("INSIDE A");}
    }

    public interface I2
    { void B_print();}

    class B : I2
    {
      public void B_print()
        {Console.WriteLine("INSIDE B");}
    }

    class AB : I1,I2
    {
        I1 ob1 = new A();
        I2 ob2 = new B();

        public void A_print()
        {
            ob1.A_print();
        }

        public void B_print()
        {
            ob2.B_print();
        }
    }

}


