using System;

namespace Senai.Tsushi.MVC.Utils
{
    public class MenuUtil
    {
        /// <summary>Exibe as opções do usuário deslogado</summary>
        public static void MenuDeslogado() {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---------- TSUSHI -----------");
            Console.WriteLine("-- (1) Cadastrar Usuário ----");
            Console.WriteLine("-- (2) Efetuar Login --------");
            Console.WriteLine("-- (3) Listar ---------------");
            Console.WriteLine("-- (0) Sair -----------------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("---- Escolha Uma Opção ------");
        }//Fim Menu Delogado
    }
}