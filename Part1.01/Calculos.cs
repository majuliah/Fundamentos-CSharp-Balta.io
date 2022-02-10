namespace Part1._01
{
    public class Calculos
    {
        public int Numero1, Numero2, Numero3;

        public int Calculando(int numero1, int numero2, int numero3)
        {
            int resultado = numero1 + numero2 + numero3;
            return resultado;
        }

        public override string ToString()
        {
            return ($"O resultado é ");
        }
    }
}