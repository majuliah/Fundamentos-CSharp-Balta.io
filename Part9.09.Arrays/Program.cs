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
            mySecondArray.Clone();
            WriteLine(mySecondArray.Length);

            foreach (int item in myFirstArray)
                WriteLine($"{item}");
            
            //
            
            var employee = new Employee[5];
            employee[0] = new Employee() {Id = 128312, Name = ($"Manny")};
            
            var employee1 = new Employee() {Id = 1289374};

            foreach (var employees in employee)
                WriteLine($"{employees.Id} and {employees.Name}");
            


        }
    }

    struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
