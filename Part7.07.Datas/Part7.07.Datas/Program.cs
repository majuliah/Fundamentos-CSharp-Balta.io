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

            //for dates we use D, M, Y
            var formatada = ($"{0:yyy}", data1);

            Console.WriteLine(data3.AddDays(20));
            Console.WriteLine(data3.AddMonths(2));

            var utcDate = DateTime.UtcNow;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate.ToLocalTime());

            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById($"Pacific/Auckland");

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);

            Console.WriteLine(horaAustralia);

            var timeSpan = new TimeSpan(1);
            Console.WriteLine(timeSpan);
            
            

        }
    }
}