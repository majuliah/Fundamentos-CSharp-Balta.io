using System;
using static System.Console;

namespace Part10._010.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Exception");

            int[] myArray = new int[5];

            try
            {
                for (int index = 0; index < 10; index++)
                    WriteLine(myArray[index]);
            }            
            catch (IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.InnerException);
                WriteLine($"Ooops, I didnt found the index at list");
            }
            catch (Exception exception)
            {

                WriteLine($"Ooops, something went wrong!");
                throw;
            }

            
            

            

        }
    }
}