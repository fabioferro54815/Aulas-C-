using System;

namespace arrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [3];

            for(int i = 0; i < numeros.Length; i++){
            System.Console.WriteLine("Digite o número da casa:");
            numeros[i] = int.Parse(Console.ReadLine());
            }

            foreach( var numero in numeros)
            {
            System.Console.WriteLine($"{numero}");
            }
        }
    }
}