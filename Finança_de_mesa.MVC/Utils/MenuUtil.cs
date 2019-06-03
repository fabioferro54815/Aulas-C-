using System;

namespace Finança_de_mesa.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            System.Console.WriteLine("     FINANÇA DE MESA     ");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("   Selecione uma opção:  ");
            System.Console.WriteLine("  1 - Cadastrar Usuário  ");
            System.Console.WriteLine("  2 - Efetuar Login      ");
            System.Console.WriteLine("  3 - Listar Usuários    ");
            System.Console.WriteLine("  0 - Sair               ");
        }

        public static void MenuLogado(){
            System.Console.WriteLine("      FINANÇA DE MESA       ");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("     Selecione uma opção:   ");
            System.Console.WriteLine("  1 - Efetuar Transação     ");
            System.Console.WriteLine("  2 - Listar Transações     ");
            System.Console.WriteLine("  3 - Exibir Extrato Total  ");
            System.Console.WriteLine("  4 - Exportar Dados Dos Usuarios        ");
            System.Console.WriteLine("  5 - Exportar Transações        ");
            System.Console.WriteLine("  6 - Exportar todos os dados em .Zip        ");
            System.Console.WriteLine("  7 - Sair da conta         ");
            System.Console.WriteLine("  0 - Sair do aplicativo    ");
        }           
    }
}