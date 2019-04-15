using System;

namespace exdowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jaAcordei = false;

            do {
                System.Console.WriteLine("Pai, você já acordou?");
                string resposta = Console.ReadLine();

                jaAcordei = resposta.Contains("que") ? true : false;
            }while (!jaAcordei);
        }
    }
}
