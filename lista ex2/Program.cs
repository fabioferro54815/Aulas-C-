using System;

namespace lista_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;

            Console.WriteLine("Veja se você pode votar!");
            Console.WriteLine("------------------------");
            Console.WriteLine("Digite seu ano de nascimento:");
            ano = int.Parse(Console.ReadLine());
            if (ano >= 2003)
            {
                Console.WriteLine("Você pode votar!");
            }else if(ano < 2003)
            {
                Console.WriteLine("Você não pode votar.");
            }

        }
    }
}
