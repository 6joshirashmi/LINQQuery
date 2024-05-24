using System;
using System.Collections.Generic;
using System.Linq;

namespace linqquery
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
public class Program
{

    public static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Id = 1, Name = "Ram" },
           // new Person { Id = 2, Name = "Vaidehi" },
             new Person { Id = 2, Name = "Vaidehi" },
           new Person { Id = 3, Name = "Anjaneya" },
            new Person { Id = 4, Name = "Ram" } // Another person named Ram
        };

        // Find all people with the name "Ram"
        var Rams = people.Where(p => p.Name == "Ram");
        foreach (var person in Rams)
        {
      //  Console.WriteLine("People named Ram:");
           // Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
        }
      // SingalQueryClass.Main2();
       FirstQueryClass.Main1();
        
    }
}
}
