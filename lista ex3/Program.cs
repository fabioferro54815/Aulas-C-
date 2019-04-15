using System;

namespace lista_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.WriteLine("Digite a senha:");
            senha = int.Parse(Console.ReadLine());
            
            switch (senha) {
                case 1234:
                    Console.WriteLine("SENHA VÁLIDA");
                    break;
                default:
                    Console.WriteLine("SENHA INVÁLIDA");
                    break;
            }
        }
    }
}
