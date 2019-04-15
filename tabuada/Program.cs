using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;

            Console.WriteLine("Bem vindo ao Qual a tabuada?!");
            Console.WriteLine("=============================");
            while(repetir){
            Console.WriteLine("Qual tabuada você quer saber?");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;

            while(cont <= 10)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine(num+"X"+cont+"="+num*cont);
                cont++;
            }
                Console.WriteLine("Você quer calcular outra tabuada?");
                string resposta = Console.ReadLine();
                repetir = resposta.Equals("sim") ? true : false;   
            }   
        }
    }
}
