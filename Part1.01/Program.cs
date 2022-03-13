using static System.Console;

namespace Part1._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Write($"Working with data types:");
            //consts:
            const int numberOne = 1;
            const double numberTwo = 2.0;

            const string genre = ($"Female Fatale");

            int _int = 20;
            double _double = 30.30;

            byte myByte = 127;
            sbyte mySbyte = -127;
            //it understands that the number isnt a number, but a byte
            // s = signed that means that it receives a sign (-127, -6, -12, etc)
            
            ushort number = 12;
            uint number2 = 123; // u means unsigned, the primitive type doesnt accepts numbers with signs (-12, -90)
            ulong number3 = 1234;

            // short and ushort = 16bits
            //int and uint = 32bits
            //long and ulong = 64bits

            float number4 = 12.3f;
            double number5 = 13.4;
            decimal number6 = 14.5m;
            
            //float 32bits 
            //double  64bits
            //decimal  128bits

            bool isTheDayHot = true;
            //bool 8bit

            char firstLetterOfMyName = 'M';
            string somLetters = "Text, some texts";

            var charsAndchars = "hasdiosahdiohsad";
            var numbers = 12;
            //receives any types

            var doesntAccepts;
            //vars needs to be declared;

            object something;
            something = 2.5;
            something = 1;
            //objects are the getaway of variables we dont know their types. 
            //different from vars, they can accept anything.

            int? isNull = null;
            


        }
    }
}