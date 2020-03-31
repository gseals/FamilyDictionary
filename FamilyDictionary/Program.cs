using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>() { { "name", "Jayde" }, { "age", "35" }  });
            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Blayde" }, { "age", "37" } });
            myFamily.Add("brother2", new Dictionary<string, string>() { { "name", "Rayde" }, { "age", "33" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "JackKnife" }, { "age", "60" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Blink" }, { "age", "60" } });

            // Next, iterate over each item in myFamily and produce the following output.
            foreach (var member in myFamily)
            {
                Console.WriteLine($"{member.Value["name"]} is my {member.Key} and is {member.Value["age"]} years old.");
                Console.ReadLine();
            }

            foreach (var (relationship, properties) in myFamily)
            {
                Console.WriteLine($"{properties["name"]} is my {relationship} and is {properties["age"]} years old.");
                Console.ReadLine();
            }
        }
    }
}
