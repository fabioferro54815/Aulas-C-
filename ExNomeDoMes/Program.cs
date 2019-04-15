using System;

namespace ExNomeDoMes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número do mês:");
            int num = int.Parse(Console.Readline());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Março");
                    break;
                default:
                    Console.WriteLine("Escolha entre 1 e 3");
                    break;
            }
        }
    }
}
