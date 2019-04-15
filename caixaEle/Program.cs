using System;

namespace caixaEle
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Bem vindo ao caixa eletrônico");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("                             ");
            System.Console.WriteLine("Digite o valor desejado:");
            int valor = int.Parse(Console.ReadLine());
            DateTime data = DateTime.Now;
            int[] notas = {100,50,20,10,5,2,1};
            for(int i = 0; i<notas.Length; i++){

            int qntdNotas = valor / notas[i];
            int restante = valor % notas[i];
            valor = restante;

                if(qntdNotas !=0){
                    System.Console.WriteLine($"Você recebeu {qntdNotas} nota(s) de {notas[i]} em {data}");
                }
            }
        }
    }
}
