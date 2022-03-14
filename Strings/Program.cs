using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Strings: ");
            string text = ($"This phrase is a test.");
            WriteLine(text.Contains($"test"));
            WriteLine(text.Contains($"Test"));
            WriteLine(text.Contains($"Test", StringComparison.Ordinal));
            WriteLine(text.Contains(null));
            //it wont work. cant compare a type null in this conditions
            
            
            WriteLine(text.StartsWith($"Este"));
            WriteLine(text.StartsWith($"este"));
            WriteLine(text.StartsWith($"texto"));
            
            WriteLine(text.EndsWith($"teste"));
            WriteLine(text.EndsWith($"Teste"));
            
            WriteLine(text.Equals($"This text is a test"));
            //equals can be compared in other types, like int, short, double, etc
            
            WriteLine(text.IndexOf($"text"));
            WriteLine(text.LastIndexOf($"text"));
            WriteLine(text.IndexOf($"text"));
            
            WriteLine(text.ToLower());
            WriteLine(text.ToUpper());
            WriteLine(text.Insert(5, $" HERE "));
            WriteLine(text.Remove(5, 5));
            WriteLine(text.Length);
            
            WriteLine(text.Replace($"this", $"THIS"));
            WriteLine(text.Replace($"i", $"W"));

            string[] division = text.Split(',');
            WriteLine(division[0]);
            WriteLine(division[1]);
            WriteLine(division[2]);
            WriteLine(division[3]);

            string result = text.Substring(5, 5);
            WriteLine(result);
            WriteLine(text.Trim());

            text += ($" here");

            var textTwo = new StringBuilder();
            textTwo.Append($"This");
            textTwo.Append($" I dont know how to put a type in textTwo");
            textTwo.ToString();
            WriteLine(textTwo);
            


        }
    }
}
