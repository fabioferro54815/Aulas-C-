using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao tsuk's Bank!");

            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = "";
            conta1.agencia = 0;
            conta1.numeroConta = 222;
            conta1.Depositar(1000);

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Victor Ivanovich";
            conta2.agencia = 132;
            conta2.numeroConta = 333;
            conta2.Depositar(3000);

            System.Console.WriteLine("Digite o nome do titular");
            conta1.titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agencia");
            conta1.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero da conta");
            conta1.numeroConta = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o quanto quer sacar ");
            double valor = double.Parse(Console.ReadLine());

            // bool resultado = conta1.Sacar(valor);

            System.Console.WriteLine("Digite o nome do titular");
            conta2.titular = Console.ReadLine();
            System.Console.WriteLine("Digite o número da agencia");
            conta2.agencia = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o numero da conta");
            conta2.numeroConta = int.Parse(Console.ReadLine());
            
            // bool resultado = conta2.Sacar(valor);

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine($"Titular {conta1.titular}");
            System.Console.WriteLine($"Agencia {conta1.agencia}");
            System.Console.WriteLine($"Numero Conta {conta1.numeroConta}");
            System.Console.WriteLine($"Saldo {conta1.saldo}");
            System.Console.WriteLine("----------------------------------");

            System.Console.WriteLine("-----------------------------------");
            System.Console.WriteLine($"Titular {conta2.titular}");
            System.Console.WriteLine($"Agencia {conta2.agencia}");
            System.Console.WriteLine($"Numero Conta {conta2.numeroConta}");
            System.Console.WriteLine($"Saldo {conta2.saldo}");
            System.Console.WriteLine("----------------------------------");

            bool resultadoTransferencia = true;

            do{
            System.Console.WriteLine("Quanto deseja tranferir da conta 1 para a conta 2");
            double valorTransferencia = double.Parse(Console.ReadLine());
            resultadoTransferencia = conta1.Transferir(valorTransferencia, conta2);
            }while(resultadoTransferencia != true);


            System.Console.WriteLine($"Saldo conta 1 {conta1.saldo}");
            System.Console.WriteLine($"Saldo conta 2 {conta2.saldo}");



        }

    }
}
