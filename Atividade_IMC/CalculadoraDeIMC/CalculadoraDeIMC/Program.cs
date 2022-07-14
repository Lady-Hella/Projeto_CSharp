using System;

namespace CalculadoraDeIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso: ");
            float peso = (float) Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            float alt = (float) Convert.ToDouble(Console.ReadLine());

            float imc = peso / (alt * alt);

            if (imc < 17)
            {
                Console.WriteLine("Muito abaixo do peso!");
            }
            else if (imc > 17 && imc < 18.49)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (imc > 18.49 && imc < 24.99)
            {
                Console.WriteLine("Peso normal!");
            }
            else if (imc > 25 && imc < 29.99)
            {
                Console.WriteLine("Acima do peso!");
            }
            else if (imc > 30 && imc < 34.99)
            {
                Console.WriteLine("Obesidade nível 1!");
            }
            else if (imc > 35 && imc < 39.99)
            {
                Console.WriteLine("Obesidade nível 2!");
            }
            else if(imc > 40)
            {
                Console.WriteLine("Obesidade mórbida!");
            }
        }
    }
}
