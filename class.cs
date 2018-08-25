using System;

namespace New_folder__2_
{
    class Program
    {
        public static void Main(string[] args)
        {   
            Customer Cust1 = new Customer("Raghav","Grover");
            Cust1.print();
            Customer  Cust2 = new Customer("Test1","Test2");
            Cust2.print();
            Customer Cust3 = new Customer();
            Cust3.print(); // this calls the no parameter constructor and that calls the 2 parameter constructor
        }

    
    }

    class Customer
    {
        string FirstName,LastName;
        
        public Customer() //calls the parametrized constructor of with 2 parameters and passes the following default values into them
        : this("no firstname","no lastname")
        {

        }
        public Customer(string FirstName,string LastName)
        {
            this.FirstName=FirstName;
            this.LastName=LastName;
        }
        public void print()
        {
            Console.WriteLine("First name : {0} Last name is : {1}",FirstName,LastName);
        }
        ~Customer()
    }



}



