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
                //for (int index = 0; index < 10; index++)
                //WriteLine(myArray[index]);

                Save("");
            }
            catch (IndexOutOfRangeException e)
            {
                WriteLine(e.Message);
                WriteLine(e.InnerException);
                WriteLine($"Ooops, I didnt found the index at list");
            }
            catch (ArgumentNullException e)
            {
                WriteLine(e.Message);
                WriteLine(e.InnerException);
                WriteLine($"Text save failed");
            }
            catch (Exception exception)
            {

                WriteLine($"Ooops, something went wrong!");
                throw;
            }
            finally
            {
                WriteLine($"Fim!");
                //doesnt expects parameters, ocurrent errors or not
            }
        }

        private static void Save(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException($"Text is null or empty!");
            }
        }
    }
}