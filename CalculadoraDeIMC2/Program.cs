using System;

namespace CalculadoraDeIMC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a sua idade: ");
            string idade = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite o peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura: ");
            float alt = (float)Convert.ToDouble(Console.ReadLine());

            float imc = peso / (alt * alt);

            if (imc < 18.5)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está muito abaixo do peso!");
            }
            else if (imc < 25)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está com o peso normal!");
            }
            else if (imc < 30)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está com sobrepeso!");
            }
            else if (imc > 30)
            {
                Console.WriteLine(nome);
                Console.WriteLine("Você está com obesidade!");
            }

        }
    }
}
