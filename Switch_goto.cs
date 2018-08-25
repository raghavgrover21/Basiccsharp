using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {
          int no;
          int cost=0;
           start:
           string another;
          no=int.Parse(Console.ReadLine());
            
           
          switch(no)
          {
              case 1 :
              Console.WriteLine("you justed added tea cost 2");
              cost=cost+2;
              break;

            case 2 :
            Console.WriteLine("added coffee cost 3");
            cost=cost+3;
            break;

            default:
            Console.WriteLine("enter a valid entry");
            break;

          }
          Console.WriteLine("total cost ",cost);

          Console.WriteLine("want another? yes/no");
          another=Console.ReadLine();  

          switch(another)
          {
              case "yes":
              goto start;
              //break;

              case "no":
              Console.WriteLine("you total is {0} ",cost);
              break;
          }

        }
    }
}
