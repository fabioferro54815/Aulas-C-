using System;

namespace lista_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;

            Console.WriteLine("Veja qual o maior número!");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());
            if(num1 > num2)
            {
                Console.WriteLine("O maior número é "+num1);
            }else if(num1 < num2)
            {
                Console.WriteLine("O maior número é "+num2);
            }
        }
    }
}
