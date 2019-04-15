using System;

namespace previsao_do_tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            string previsao;
            string resposta;

            Console.WriteLine("Bem Vindo ao Aconselhador de Rolê!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Qual a Previsão de hoje?");
            previsao = Console.ReadLine().ToLower();

            if (previsao.Equals("frio"))
            {
                Console.WriteLine("Vamos a montanha!");
            }
            else if(previsao.Equals("calor"))
            {
                Console.WriteLine("Vamos à praia!");
            }
            else if(previsao.Equals("chuva"))
            {
                Console.WriteLine("Vamos a Steam?");
                resposta = Console.ReadLine();
                if (resposta.Equals("não"))
                {
                    Console.WriteLine("Então vamos ao Netflix!");
                }
            }else{
                    Console.WriteLine("Valor inválido \n Digite: chuva, frio ou calor");
            }                
            }
        }
    }