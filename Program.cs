namespace Ejercicio_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de metodos");
            Console.WriteLine("Ponemos un bucle");
        }

        static double Suma(double num1, double num2)
        {
            double resultado = num1 + num2;
            return resultado;
        }

        static double Resta(double num1, double num2)
        {
            double resultado = num1 - num2;
            return resultado;
        }
        static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
    }
}
