using System;

namespace forEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string estrela = "";
            
            System.Console.WriteLine("Digite a quantidade:");
            n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n ; i++)
            {
                estrela +="*";
                System.Console.WriteLine(estrela);
            }
        }
    }
}