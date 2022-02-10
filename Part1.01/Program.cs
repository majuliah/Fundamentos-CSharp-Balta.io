using static System.Console;

namespace Part1._01
{
    class Program
    {
        static void Main(string[] args)
        { 
            WriteLine("Fundamentals");

            Calculos calculo = new Calculos();
            int resultado;

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            
            calculo.Calculando(num1, num2, num3);

            resultado = calculo.Calculando(num1, num2, num3);
            
            WriteLine($"Resultado: {resultado.ToString()}");
            

        }
    }
}