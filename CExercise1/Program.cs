using System;

namespace CExercise1
{
    class Program
    {

        class Fishing
        {
            public string Type { get; set; }
            public string Location { get; set; }
        }

        class Books
        {
            public string Type { get; set; }
            public string Cover { get; set; }
        }

        class Tacos
        {
            public string Type { get; set; }
            public string Meat { get; set; }
        }

        class Shoes
        {
            public string Type { get; set; }
            public string Brand { get; set; }
        }


        static void Main(string[] args)
        {

            Fishing fishLocation = new Fishing
            {
                Type = "Trout",
                Location = "Cherokee"
            };

            Books newBook = new Books();
            newBook.Type = "Harry Potter";


            Console.WriteLine("I fish for {0} inside of {1} while " +
                "reading {2}",fishLocation.Type, fishLocation.Location, newBook.Type );
            Console.ReadLine();
            
        }
    }

   
}
