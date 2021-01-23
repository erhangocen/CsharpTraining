using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer = new Costumer
            {
                Id = 1,
                FirstName = "Erhan",
                LastName = "Göcen",
                City = "Ankara"
            };

            Costumer costumer2 = new Costumer
            (
                2,
                "Eren",
                "Birk",
                "İstanbul"
            );

            Console.WriteLine(costumer2.LastName);
        }
    }

    class Costumer
    {
        public Costumer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        
        public Costumer()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
