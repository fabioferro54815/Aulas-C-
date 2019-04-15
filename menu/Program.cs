using System;

namespace menu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = true;
            Console.WriteLine("Aplicação - Criando Menus");

            while(repetir)
            {
                Console.WriteLine("Selecione uma opção desejada");
                Console.WriteLine("============================");             
                Console.WriteLine("Digite 1 para efetuar o login");                
                Console.WriteLine("Digite 2 para contato");               
                Console.WriteLine("Digite 3 para listar comentários");
                Console.WriteLine("Digite 9 para sair");
                int resposta = int.Parse(Console.ReadLine());

                switch(resposta)
                {
                    case 1:
                        Console.WriteLine("Digite seu usuario:");
                        string usuario = Console.ReadLine();
                        if(usuario.Equals("Fabio"))
                        {
                            Console.WriteLine("Digite sua senha");
                            int senha = int.Parse(Console.ReadLine());
                            if(senha.Equals(1234))
                            {
                                Console.WriteLine("=========================");
                                Console.WriteLine("Bem Vindo(a) {0}", usuario);
                            }else{
                                Console.WriteLine("Senha incorreta!");
                            }
                        }else{
                            Console.WriteLine("Usuário incorreto");
                        }
                        break;
                    case 2:
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Tsukaoto - 9444444444");
                        Console.WriteLine("Cesar - 9222222222");
                        Console.WriteLine("----------------------");
                        break;
                    case 3:
                        Console.WriteLine("----------------------");
                        Console.WriteLine("Amei o programa!!!!");
                        Console.WriteLine("Os desenvolvedores são incriveis!!!");
                        Console.WriteLine("----------------------");
                        break;
                    case 9:
                        Console.WriteLine("Adeus!");
                        repetir = false;
                        break;
                }
                



            }//fim while
        }//fim main
    }
}
