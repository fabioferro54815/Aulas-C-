using System;

namespace passagem
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [5];
            int [] numPass = new int [5];
            DateTime [] data = new DateTime[5];

            bool repetir = true;
            int i = 0;

            System.Console.WriteLine("                            ");
            System.Console.WriteLine("============================");
            System.Console.WriteLine("Bem vindo ao Tsuks Airlines!");
            System.Console.WriteLine("============================");
            System.Console.WriteLine("                            ");
            while(repetir){
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("                            ");
            System.Console.WriteLine("           MENU             ");
            System.Console.WriteLine("                            ");
            System.Console.WriteLine("  1 - Registrar Passagem    ");
            System.Console.WriteLine("  2 - Visualizar Passagens  ");
            System.Console.WriteLine("  0 - Sair                  ");
            System.Console.WriteLine("                            ");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("Digite a opção desejada: ");
            int resposta = int.Parse(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                    if(i>=5){
                        System.Console.WriteLine("-----------------------------");
                        System.Console.WriteLine("Limite de cadastros alcançado");
                        System.Console.WriteLine("-----------------------------");
                    }else{
                        System.Console.WriteLine("-----------------------------");
                        System.Console.WriteLine("Digite o Nome do Comprador: ");
                        nomes[i] = Console.ReadLine();
                        System.Console.WriteLine("-----------------------------");
                        System.Console.WriteLine("Digite o N° da passagem: ");
                        numPass[i] = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("-----------------------------");
                        System.Console.WriteLine("Digite a data: dd/mm/aa ");
                        data[i] = DateTime.Parse(Console.ReadLine());
                        System.Console.WriteLine("                               ");
                        System.Console.WriteLine("===============================");
                        System.Console.WriteLine("Cadastro realizado com sucesso!");
                        System.Console.WriteLine("===============================");
                        i++;
                    }
                        break;
                    case 2:
                        int x = 1;
                    for(int j = 0; j<i; j++){
                        System.Console.WriteLine("=======================================");
                        System.Console.WriteLine($"          PASSAGEM N°{x}             ");
                        System.Console.WriteLine($"Nome: {nomes[j]}");
                        System.Console.WriteLine($"N° da passagem: {numPass[j]}");
                        System.Console.WriteLine($"Data: {data[j]:dd/MMMM/yyyy}");
                        System.Console.WriteLine("=======================================");
                        x++;
                    }
                        break;
                    case 0:
                        System.Console.WriteLine("=======================================");
                        System.Console.WriteLine("OBRIGADO POR ESCOLHER A TSUKS AIRLINES!");
                        System.Console.WriteLine("=======================================");
                        repetir = false;
                        break;
                    default:
                    System.Console.WriteLine("==============================");
                    System.Console.WriteLine("--------NÚMERO ÍNVALIDO-------");
                    System.Console.WriteLine("==============================");
                        break;                    
                }
            }
        }
    }
}