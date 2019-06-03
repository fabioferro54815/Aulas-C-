using System;
using Senai.Tsushi.MVC.Utils;
using Senai.Tsushi.MVC.ViewModel;

namespace Senai.Tsushi.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado)
                {
                    case 1:
                    //Cadastro Usuário//
                
                    break;
                    case 2:
                    //Efetua Login//

                    break;
                    case 3 :
                    //Listar//

                    break;
                    case 0:
                    //Sair//
                    break;
                    default:
                        System.Console.WriteLine("Opção Inválida");
                    break;
                }

            }while(opcaoDeslogado != 0);
        }
    }
}
