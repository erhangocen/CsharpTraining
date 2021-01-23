using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";
            person2 = person1;
            person1.FirstName = "Erhan";

            Console.WriteLine(person2.FirstName);

            Costumer costumer = new Costumer();
            costumer.FirstName = "Salih";
            costumer.CreditCardNumber = 2222222222222;

            Employe employe = new Employe();
            employe.FirstName = "Ali";

            Person person3 = costumer;

            Console.WriteLine(((Costumer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employe);
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Costumer:Person
        {
            public long CreditCardNumber { get; set; }
        }

        class Employe:Person
        {
            public int EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
