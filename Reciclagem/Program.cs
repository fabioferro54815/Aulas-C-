using System;
using Reciclagem.Interfaces;
using Reciclagem.Models;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            do
            {
                System.Console.WriteLine("        LIXEIRA         ");
                System.Console.WriteLine("                        ");
                System.Console.WriteLine("   1 - Garrafa de Skol  ");
                System.Console.WriteLine("   2 - Copo Descartavel ");
                System.Console.WriteLine("   3 - Latinha de Coca  ");
                System.Console.WriteLine("   4 - Folha de caderno ");
                System.Console.WriteLine("   5 - Fita Adesiva     ");
                System.Console.WriteLine("   6 - Maça Podre       ");
                System.Console.WriteLine("                        ");
                System.Console.WriteLine("       0 - SAIR         ");
                int codigo = int.Parse(Console.ReadLine());

                CartaVelha cv = new CartaVelha();
                FolhaCaderno fc = new FolhaCaderno();

                JogarPapelNoLixo(fc);

                switch(codigo)
                {
                    case 1:
                        
                    break;

                    case 2:
                        
                    break;

                    case 3:
                        
                    break;

                    case 4:
                        
                    break;

                    case 5:
                        
                    break;

                    case 6:
                        
                    break;

                    case 0:
                        
                    break;
                }
            }while(!sair);
        }

        public static void Reciclar(){
            Type tipoLixo = lixo.GetType().GetInterface().FisrtOrDefault();
        }

        public static void JogarPapelNoLixo(IPapel papel) 
        {
            papel.AlocarLixo();
        }
    }
}
