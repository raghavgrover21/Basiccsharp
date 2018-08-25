using System;

    namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            string name=Console.ReadLine();
            int roll=int.Parse(Console.ReadLine());  
            Student ob1 = new Student();
            ob1.set_Name(name);
            name=ob1.get_Name();
            ob1.set_Roll(roll);
            roll=ob1.get_Roll();
            
            Console.WriteLine(" name -{0} ",name);
            Console.WriteLine(" roll number - {0}",roll);
        
        }

        
    }
    public class Student

    {
        private string name;
        private int roll;
        
        public void set_Name(string name)
        {   
            //[ return string.IsNullOrEmpty(this.name) ? "invalid name" : this.name; ] //try to use ternary operator as much as possible
             if(string.IsNullOrEmpty(name)==true)           //good way to check a string is null or empty OR simply check for NULL assignments;
                {
                   this.name="invalid name";
                    throw new Exception("name cannot be null or empty");
                }
           
            else{
                 this.name=name;
                }
        }
        public string get_Name()
        {
           if(string.IsNullOrEmpty(this.name))
                return "invalid name";

                else 
                return this.name;
        }

        public void set_Roll(int roll)
        {
            if(roll>0)
            {
            this.roll=roll;
            }
            
            else
            throw new Exception("Please enter a valid roll no");
            
            
        }
        public int get_Roll()
        {
            return this.roll;
        }
        

    }

   

}



