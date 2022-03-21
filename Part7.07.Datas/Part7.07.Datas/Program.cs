using System;

namespace Part7._07.Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var data = new DateTime();
            var data1 = DateTime.Now;
            var data2 = new DateTime(2020, 10, 12);
            var data3 = new DateTime(2020, 10, 12);
            Console.WriteLine(data);
            Console.WriteLine(data1);
            Console.WriteLine(data3.Year);
            
        }
    }
}