using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Fatih";

            Console.WriteLine(customer2.FirstName);
        }

    class Customer
        {
            public Customer()   //default constructor
            {
 
            }
            public Customer(int id, string firstName, string lastName, string city)   //default constructor
            {
                FirstName = firstName;
                LastName = lastName;
                Id = id;
                City = city;
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }

        }
    }
}
