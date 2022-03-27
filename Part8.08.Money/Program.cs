using System;
using System.Globalization;
using static System.Console;

namespace Part8._08.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            decimal value = 10235.25m;
            
            WriteLine(value.ToString(CultureInfo.CreateSpecificCulture("en-US")));
                                                                                //passing a specific culture;

                                                                                
            WriteLine(value.ToString(CultureInfo.CreateSpecificCulture($"pt-BR")));
            
            WriteLine(value.ToString($"C",CultureInfo.CreateSpecificCulture($"pt-BR")));
                                           //format C is Currence, that brings a money.
            WriteLine(value.ToString($"G",CultureInfo.CreateSpecificCulture($"pt-BR")));
                                           //format G is numeric formatter 
            WriteLine(value.ToString($"F",CultureInfo.CreateSpecificCulture($"pt-BR")));
                                          //format F is separator, with a bigger precision, is how many cases after 0 you want to show

            decimal methodCalcules = Math.Round(value);
            decimal methodCalcules1 = Math.Ceiling(value);
            decimal methodCalcules2 = Math.Floor(value);
            
            



        }                                 
        
        
        
    }
}