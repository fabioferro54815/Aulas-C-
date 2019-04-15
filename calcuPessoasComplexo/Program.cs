using System;

namespace calcuPessoasComplexo
{
    class Program
    {
        static void Main(string[] args)
        {
            int masculino = 0;
            int feminino = 0;
            double mediaMasculino = 0;
            double mediaFeminino = 0;
            double pesoMasculino =0;
            double pesoFeminino =0;
            
            System.Console.WriteLine("Calculador de informações das pessoas:");
            System.Console.WriteLine("--------------------------------");
            for (int pergunta = 1; pergunta <= 10; pergunta++)
            {
                Console.WriteLine("Digite o sexo:");
                string sexo = Console.ReadLine();
                if(sexo.Equals("masculino"))
                {
                    masculino++;
                }else if(sexo.Equals("feminino"))
                {
                    feminino++;
                }
                Console.WriteLine("Digite a idade:");
                int idade = int.Parse(Console.ReadLine());
                if(sexo.Equals("masculino"))
                {
                    mediaMasculino = idade / masculino;
                }else{
                    mediaFeminino = idade / feminino;
                }
                Console.WriteLine("Digite o peso:");
                double peso = double.Parse(Console.ReadLine());
                if(sexo.Equals("masculino"))
                {
                    pesoMasculino = peso / masculino;
                }else{
                    pesoFeminino = peso / feminino;
                }
                
            }//fim for
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine("Total de homens: "+masculino);
            System.Console.WriteLine("Total de mulheres: "+feminino);
            System.Console.WriteLine("Média da idade dos homens: "+mediaMasculino);
            System.Console.WriteLine("Média da idade das mulheres: "+mediaFeminino);
            System.Console.WriteLine("Média do peso dos homens: "+pesoMasculino);
            System.Console.WriteLine("Média do peso das mulheres: "+pesoFeminino);
        }
    }
}
