using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqquery
{
    public class SingalQueryClass
    {
    
   

    public static void Main2()
    {
        List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "Ram" },
            new Person { Id = 2, Name = "Vaidehi" },
           //  new Person { Id = 2, Name = "Vaidehi" },
            new Person { Id = 3, Name = "Anjaneya" },
            new Person { Id = 4, Name = "Ram" } // Another person named Ram
        };       
        // Find the single person with the Id 2
        var personWithId2 = people.SingleOrDefault(p => p.Id == 2);
        if (personWithId2 != null)
        { Console.Write(" the single person with the Id 2:");
            Console.WriteLine($"\nSingle person with Id 2: Id: {personWithId2.Id}, Name: {personWithId2.Name}");
        }

        // Attempt to find a single person with the name "Ram" (this will throw an exception)
        try
        {
            var singleRam = people.Single(p => p.Name == "Ram");
        }
        catch (Exception ex)
        { Console.WriteLine("Exception: with Singal");
            Console.WriteLine($"\nException: {ex.Message}");
        }
    }
}
}
