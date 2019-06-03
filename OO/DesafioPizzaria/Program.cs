using System;

namespace DesafioPizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bem vindo a Pizzaria do Tsukamoto");
           int escolha = 0;
           do{
               
               Console.WriteLine("1 -- Cadastrar Usuário");
               Console.WriteLine("2 -- Login");
               Console.WriteLine("3 -- Listar Usuário");
               Console.WriteLine("9 - Sair");
               escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                    //Cadastro do usuário
                         Usuario.Inserir();
                    // Usuario.Listar();
                    break;
                    case 2:
                    // Efetuar login
                    Usuario.EfetuarLogin();
                        //Colocar o segundo Menu
                        int escolha2 = 0;
                        do{

                            Console.WriteLine("1 -- Cadastrar Produto");
                            Console.WriteLine("2 -- Listar Produtos");                            
                            Console.WriteLine("3 -- Buscar Pela ID");
                            Console.WriteLine("9 -- Sair");
                            escolha2 = int.Parse(Console.ReadLine());

                            switch(escolha2)
                            {
                                case 1:
                                    Produto.Cadastrar();
                                break;

                                case 2:
                                    Produto.listarProduto();
                                break;

                                case 3:
                                    Produto.BuscarId();
                                break;

                                case 9:
                                    //sair do menu
                                break;
                                default:
                                    System.Console.WriteLine("Valor ínvalido");
                                break;
                            }

                        }while(escolha2!=9);
                    break;
                    case 3:
                    // Listar Usuarios
                    Usuario.Listar();
                    break;
                    case 9:
                    // Sair do sistema
                    break;
                    
                    default:
                        Console.WriteLine("Valor inválido");
                    break;
                }

           }while(escolha != 9);

        
        }
    }
}
