using System;

namespace App_Media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Média");
            float nota1;
            float nota2;
            float nota3;
            int faltas;
            float soma;
            Console.WriteLine("Digite a 1° nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota:");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 3° nota:");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de faltas:");
            faltas = int.Parse(Console.ReadLine());
            soma = nota1 + nota2 + nota3;
            double media = soma/3;
            Console.WriteLine("A soma das notas é: "+soma+" e a media é: "+media+"      N° de Faltas: "+faltas);
            if (media < 5 || faltas > 25){
                Console.WriteLine("Aluno Reprovado");
            }else if (media < 9){
                Console.WriteLine("Aluno Aprovado");
            }else{
                Console.WriteLine("É isso ai jovem");
            }
        }
    }
}
