using System;
using System.IO;
// using directive;
    namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            try{
            StreamReader Sreader = new StreamReader(@"C:\Users\Albo\esktop\New folder (2)\File1.txt");
            Console.WriteLine(Sreader.ReadToEnd());
            Sreader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found",ex.Message);
            } 
            
       
        }
   

    }
}



