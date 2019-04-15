using System;

namespace baladinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string dia;
            int idade;
            string tipo;
            string entrada;

            Console.WriteLine("Bem vindo ao posso ir pra baladinhas!");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Tem Compromisso no dia?");
            dia = Console.ReadLine().ToLower();
            if (dia.Equals("sim"))
            {
                Console.WriteLine("Você tem compromisso no dia, não vá.");
            }
            else if (dia.Equals("não"))
            {   
                Console.WriteLine("Balada +18 ou Matinê?");
                tipo = Console.ReadLine().ToLower();
                if (tipo.Equals("matinê"))
                {
                    Console.WriteLine("Quantos anos você tem?");
                    idade = int.Parse(Console.ReadLine().ToLower());
                    if (idade > 18)
                    {
                        Console.WriteLine("Você não tem idade para ir.");
                    }else if(idade < 18)
                    {
                        Console.WriteLine("Tem pulseira V.I.P ou pagou a entrada?");
                        entrada = Console.ReadLine().ToLower();
                        if (entrada.Equals("pulseira"))
                        {
                            Console.WriteLine("Sextouuuu!!!!!");
                        }else if(entrada.Equals("paguei a entrada"))
                        {
                            Console.WriteLine("Sextouuuu!!!!!");
                        }if (entrada.Equals("não"))
                        {
                            Console.WriteLine("Você não tem como entrar.");
                        }
                    }

                }else if (tipo.Equals("balada +18"))
                {
                    Console.WriteLine("Quantos anos você tem?");
                    idade = int.Parse(Console.ReadLine().ToLower());
                    if (idade < 18){
                        Console.WriteLine("Você não tem idade para ir.");
                    }else if (idade >= 18){
                        Console.WriteLine("Tem pulseira V.I.P ou pagou a entrada?");
                        entrada = Console.ReadLine().ToLower();
                        if (entrada.Equals("pulseira"))
                        {
                            Console.WriteLine("Sextouuuu!!!!!");
                        }else if(entrada.Equals("paguei a entrada"))
                        {
                            Console.WriteLine("Sextouuuu!!!!!");
                        }if (entrada.Equals("não"))
                        {
                            Console.WriteLine("Você não tem como entrar.");
                        }
                    }

                }
            }
        }
    }
}
