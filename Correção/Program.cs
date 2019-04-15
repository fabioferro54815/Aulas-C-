using System;

namespace Correção
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMaquina = 0;
            int numeroUsuario = 0;

            string escolhaUsuario = "";
            string respostaUsuario = "";

            Console.WriteLine ("Olá! Gostaria de jogar par ou ímpar comigo?");
            respostaUsuario = Console.ReadLine ();

            if ("sim".Equals (respostaUsuario, StringComparison.CurrentCultureIgnoreCase)) {
                Console.WriteLine ("===================================");
                Console.WriteLine ("= *-* Beleza! Vamos lá então! *-* =");
                Console.WriteLine ("===================================");
                Console.WriteLine ("Escolha um: Par ou Impar");

                escolhaUsuario = Console.ReadLine ();

                if ("par".Equals (escolhaUsuario, StringComparison.CurrentCultureIgnoreCase) ||
                    "impar".Equals (escolhaUsuario, StringComparison.CurrentCultureIgnoreCase)) {

                    if ("par".Equals (escolhaUsuario, StringComparison.CurrentCultureIgnoreCase)) {
                        Console.WriteLine ("Vou de Impar, então");

                    } else {
                        Console.WriteLine ("Vou de Par, então");
                    }

                    Console.WriteLine ("Escolha um número de 0 até 10");
                    respostaUsuario = Console.ReadLine ();

                    if (int.TryParse (respostaUsuario, out numeroUsuario) 
                        && numeroUsuario >= 0 
                        && numeroUsuario <= 10 ) {

                        Console.WriteLine ("Você escolheu: {0}", numeroUsuario);
                        Random r = new Random ();
                        numeroMaquina = r.Next (0, 10);

                        Console.WriteLine ("Ok! Eu escolho o {0}", numeroMaquina);

                        if (((numeroUsuario + numeroMaquina) % 2 == 0  
                                && "par".Equals (escolhaUsuario, StringComparison.CurrentCultureIgnoreCase)) 
                                    || 
                            ((numeroUsuario + numeroMaquina) % 2 != 0 
                                && "impar".Equals (escolhaUsuario, StringComparison.CurrentCultureIgnoreCase))) {
                            
                            Console.WriteLine ("Droga, você venceu!");

                        } else {
                            Console.WriteLine ("Eu venci! Huehuebrbr!");
                        }

                    } else {
                        Console.WriteLine ("Noob!");
                    }

                } else {
                    Console.WriteLine ("...");
                }

            } else {
                Console.WriteLine ("VLW FLW");
            }
        }
    }
}
