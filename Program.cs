using System;
using System.Globalization;

namespace Exercicios2Udemy
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();
            Console.WriteLine(nome);

            Console.WriteLine("Quantos quartos tem em sua casa");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine(quartos);

            Console.WriteLine("Entre com o preço do produto ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(preco.ToString("f2", CultureInfo.InvariantCulture));

            Console.WriteLine("entre com o seu ultimo nome, idade e altura na mesma linha");
            String [] vet = Console.ReadLine().Split(' ');
            String ultimo = vet[0];
            int idade = int.Parse (vet[1]);
            double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);
            
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2],CultureInfo.InvariantCulture);
            
            



            

        }

    }

}