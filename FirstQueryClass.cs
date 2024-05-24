using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqquery
{
    public class FirstQueryClass
    {
    public static void Main1()
    {
        List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "Ram" },
           // new Person { Id = 2, Name = "Vaidehi" },
             new Person { Id = 2, Name = "Vaidehi" },
            new Person { Id = 3, Name = "Anjaneya" },
            new Person { Id = 4, Name = "Ram" } // Another person named Ram
        };
         // Find the first person with the name "Anjaneya"
        var firstAnjaneya = people.FirstOrDefault(p => p.Name == "Anjaneya");
        if (firstAnjaneya != null)
        {
 Console.Write(" the first person with the name Anjaneya:");
            Console.WriteLine($"\nFirst Anjaneya found: Id: {firstAnjaneya.Id}, Name: {firstAnjaneya.Name}");
        }
 // Attempt to find a First person with the name "poko" (this will throw an exception)
        try
        {
            var singleRam = people.First(p => p.Name == "Poko");
        }
        catch (Exception ex)
        { Console.WriteLine("Exception: with First");
            Console.WriteLine($"\nException: {ex.Message}");
        }
         // Attempt to find a First person with the name "poko" (this will throw an exception)
        try
        {
            var singleRam = people.FirstOrDefault(p => p.Name == "Poko");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: with FirstOrDefault");
            Console.WriteLine($"\nException: {ex.Message}");
        }
    }
}
}