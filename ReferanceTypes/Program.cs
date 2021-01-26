using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person1 = person2;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            //customer=employee //farklı tipte oldukları için birbirine atanamazlar. int e string atanamaz gibi
            Person person3 = customer;  
            customer.FirstName = "Ahmet";
            Console.WriteLine(person3.FirstName);
            
            Console.WriteLine(((Customer)person3).CreditCardNumber);  //person3 e Customer baxing'i yaptık.

            PersonManager personManager = new PersonManager();
            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);

        }

    class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        //base class : Person
    class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }


        //base class : Person
    class Employee: Person
        {
            public int EmployeeNumber { get; set; }
        } 
    
    class PersonManager
        {
            public void Add(Person person) //parametreyi customer veya employee almadık ikisinin de base si olan person aldık
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
