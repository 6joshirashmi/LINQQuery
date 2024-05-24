using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linqquery
{
    public class NumberOfVowelClass
    {
    public static void Main3()
    {
        string input = "Hello, how many vowels are in this sentence?";
        int vowelCount = CountVowels(input);
        Console.WriteLine($"Number of vowels in the given string: {vowelCount}");
    }


    
    public static int CountVowels(string input)
    {
        // Define the vowels
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        // Use LINQ to count the vowels
        int count = input.Count(c => vowels.Contains(c));
        
        return count;
    }
    }
}