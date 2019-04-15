using System;

namespace forDuplo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite o tamanho do triangulo");

            for(int j = 1; j <= 3; j++){
            string estrela = "";
                for(int i = 1; i <= 3 ; i++)
                {
                    estrela +="*";
                    System.Console.WriteLine($"{estrela}");
                }
            }
        }
    }
}
