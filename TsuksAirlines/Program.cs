using System;

namespace TsuksAirlines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a TsuksAirlines!");
            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int passageirosCadastrados = 0;

            do {
                System.Console.WriteLine("Escolha uma opção: ");
                System.Console.WriteLine("1 - Registrar Passageiro");
                System.Console.WriteLine("2 - Exibir Passagens");
                System.Console.WriteLine("0 - Sair");

                int codigo = int.Parse(System.Console.ReadLine());

                switch(codigo) {
                    case 1:
                        Passageiro p = new Passageiro();
                        System.Console.WriteLine("Digite nome");
                        p.setNome(Console.ReadLine());

                        System.Console.WriteLine("Digite o numero da passagem");
                        p.setnumeroPassagem(int.Parse(Console.ReadLine()));

                        System.Console.WriteLine("Digite a data");
                        p.setdata(DateTime.Parse(Console.ReadLine()));
                        
                        passageiros[passageirosCadastrados] = p;

                        passageirosCadastrados++;
                        System.Console.WriteLine("Passageiro cadastrado com sucesso!");
                    break;
                    case 2:
                        System.Console.WriteLine("Todos os passageiros cadastrados: ");
                        for (int i = 0; i < passageirosCadastrados; i++)
                        {
                            System.Console.WriteLine(passageiros[i].getNome());
                            System.Console.WriteLine(passageiros[i].getnumeroPassagem());
                            System.Console.WriteLine($"{passageiros[i].getdata():dd--MMMM--yyyy}");
                        }
                    break;
                    case 0:
                        sair = true;
                    break;
                }
            }while (!sair);
        }
    }
}
