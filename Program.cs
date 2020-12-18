using System;

namespace project
{
    class Program
    {
        static void Main(string[] args)
        {   
            string descricao;
            Console.WriteLine("Informe a descrição do produto:");
            descricao = Console.ReadLine();

            int valor;
            Console.WriteLine("Informe o valor do produto:");
            valor = int.Parse(Console.ReadLine());

            double quantidade;
            Console.WriteLine("Informe a quantidade do produto.");
            quantidade = double.Parse(Console.ReadLine());
        }
    }
}
