using System;

namespace pizztsuka
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repetir = false;
            usuario[] users = new usuario[2];
            int userCadastrados = 0;
            int idNum = 1;
            do{
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine("Bem vindo ao PizzTsuka!");
                Console.ResetColor();
                System.Console.WriteLine("                       ");
                System.Console.WriteLine(" 1 - Cadastro");
                System.Console.WriteLine(" 2 - Efetuar Login");
                System.Console.WriteLine(" 3 - Listar Usuários");
                System.Console.WriteLine(" 9 - Sair");
                System.Console.WriteLine("                       ");
                System.Console.Write("Digite a opção desejada: ");
                int codigo = int.Parse(Console.ReadLine());

                switch(codigo){
                    case 1 :
                        usuario user = new usuario();

                        System.Console.WriteLine("Cadastre-se: ");

                        System.Console.WriteLine("Digite o nome a ser cadastrado: ");
                        user.nome = Console.ReadLine();

                        System.Console.WriteLine("Digite o email a ser cadastrado:");
                        user.email = Console.ReadLine();
                        if(user.email.Contains("@")){
                            
                        }if(user.email.Contains(".")){
                            
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("O email tem valores ínvalidos!");
                            Console.ResetColor();
                            break;
                        }

                        System.Console.WriteLine("Cadastre uma senha de no mínimo 6 caracteres: ");
                        user.senha = Console.ReadLine();
                        if(user.senha.Length < 6){
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Senha muito curta!");
                            Console.ResetColor();
                            break;
                        }else{
                            Console.ForegroundColor = ConsoleColor.Green;
                            System.Console.WriteLine("Cadastro Realizado Com Sucesso!");
                            Console.ResetColor();
                        }

                        users[userCadastrados] = user;

                        userCadastrados++;

                        user.id  = idNum;
                        idNum += 1;
                    break;

                    case 2:
                        System.Console.WriteLine("Digite o email: ");
                    break;

                    case 3:
                    for(int i = 0; i > users.Length; i++)
                        System.Console.WriteLine(users[i].Listar());
                    break;

                    case 9:
                        repetir = true;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        System.Console.WriteLine("Obrigado por escolher a PizzTsuks!");
                        Console.ResetColor();
                    break;
                }



            }while(!repetir);
        }
    }
}
