using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {   
           int result;
           Circle ob1 = new Circle(7);
           result=ob1.area();
           Console.WriteLine("this is the result{0}",result);

           Circle ob2 = new Circle(6);
           result=ob2.area();
           Console.WriteLine("this is the result{0}",result);
           
        }
    
    }
    class Circle
    {
        static float pi= 3.14f; // every time a function needs this value then it will 
                                // point to a value on the stack(on which static variable resides on .created only once) and get that value;
        int radius;
        flaot area;
        public Circle(int radius)
        {
            this.radius=radius;
        }

        public int area()
        {
            area=radius*radius*pi;
            
        }
    }

}



