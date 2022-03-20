using System;
using System.Text;

namespace HTMLeditor
{
    public class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            
            Console.Clear();
            Console.WriteLine($"-- ** EDITOR MODE ** --");
            Console.WriteLine($"-- ***************** --");
            
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.DownArrow);
            
            Console.WriteLine($"-- ***************** --");
            Console.WriteLine($"Do you want to save file?");
            Viewer.Show(file.ToString());
            //implementar se ele deseja ou não salvar o arquivo :)
        }
    }
}