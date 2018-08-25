using System;

    namespace New_folder__2_
{
    public class Program
    {
        public static void Main(string[] args)
        
        {
            Console.Write("working");
             string Name=Console.ReadLine();   
             int id=int.Parse(Console.ReadLine());  
            Student ob1 = new Student();
            ob1.id=id; //passing id into the id (get,set)
            ob1.name=Name;//passing name into the name (get,set)
            Console.WriteLine("student id is {0}",ob1.id);
            
            Console.WriteLine("student name is {0}",ob1.name);

        }

        
    }
    public class Student

    {
        private int Id;        
        private string Name;
        public int id
        {
            set
            {
                if(value<=0)    //value passed from main ob1.id=(id=which was passed)
                {
                    throw new Exception("student id cannot be 0 or less than 0");
                }
                else 
                this.Id=value;  //return the
            }
            get
            {
                return this.Id; 
            }
        } 
        public string name
        {
        set
            {
                if(string.IsNullOrEmpty(value))//checking if value entered by user is valid or not 
                {
                throw new Exception("name cannot be null");
                }
                this.Name=value;  //set if valid
                
            }
        get
            {
                return string.IsNullOrEmpty(this.Name)? "invalid name" : this.Name; //check again if string is empty
                                                        //(incase this property is called directly hence we need a check here as well)
            }    
        }
    }

   

}



