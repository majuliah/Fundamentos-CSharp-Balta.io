using static System.Console;

namespace Part9._09.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            WriteLine("Hello Arrays!");

            int[] myFirstArray = new int[5]{ 1, 2, 3, 4, 5 };
            myFirstArray[0] = 12;
            
            WriteLine(myFirstArray[0]);
            WriteLine(myFirstArray[1]);
            WriteLine(myFirstArray[2]);
            WriteLine(myFirstArray[3]);
            WriteLine(myFirstArray[4]);

            int[] mySecondArray = new int[5];
            mySecondArray[0] = 11;
            mySecondArray[2] = 13;
            


        }
    }
}