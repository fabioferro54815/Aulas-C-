using System;

namespace calcuPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior18 = 0;
            System.Console.WriteLine("Calculador da idade das pessoas:");
            System.Console.WriteLine("--------------------------------");
            for (int pergunta = 1; pergunta <= 10; pergunta++)
            {
                Console.WriteLine("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());
                if (idade >= 18)
                {
                    maior18++;
                }
            }//fim for
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("A quantidade de maiores de 18 anos é: "+maior18);
        }
    }
}
