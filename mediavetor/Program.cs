using System;

namespace mediavetor {
    class Program {
        static void Main (string[] args) {
            string[] nomes = new string[2];
            string[] sobrenomes = new string[2];
            float[] nota1 = new float[2];
            float[] nota2 = new float[2];
            float[] media = new float[2];
            float[] soma = new float[2];
            int x = 1;
            bool valor1 = true;
            bool valor2 = true;

            System.Console.WriteLine("===========================");
            System.Console.WriteLine("     RELATÓRIO ESCOLAR"     );
            System.Console.WriteLine("===========================");

            for (int i = 0; i < nomes.Length; i++) {
                Console.WriteLine ($"Digite o nome do {x}° aluno: ");
                nomes[i] = Console.ReadLine ();

                System.Console.WriteLine ("Digite o sobrenome do aluno: ");
                sobrenomes[i] = Console.ReadLine ();

                System.Console.WriteLine ("Digite a 1° nota: ");
                valor1 = float.TryParse (Console.ReadLine (), out nota1[i]);
                if (valor1 !=true){
                    System.Console.WriteLine("--------------");
                    System.Console.WriteLine("VALOR ÍNVALIDO");
                    System.Console.WriteLine("--------------");
                }

                System.Console.WriteLine ("Digite a 2° nota: ");
                valor2 = float.TryParse (Console.ReadLine (), out nota2[i]);
                if(valor2 !=true){
                    System.Console.WriteLine("--------------");
                    System.Console.WriteLine("VALOR ÍNVALIDO");
                    System.Console.WriteLine("--------------");
                }
                
                soma[i] = nota1[i] + nota2[i];
                media[i] = soma[i] / 2;

                x++;
            }
            for (int i = 0; i < nomes.Length; i++) {
                System.Console.WriteLine ("---------------------------");
                System.Console.WriteLine ($"Nome: {nomes[i]}");
                System.Console.WriteLine ($"Sobrenome: {sobrenomes[i]}");
                System.Console.WriteLine ($"Média: {media[i]}");
                if (media[i] >= 50) {
                    System.Console.WriteLine ($"Situação do aluno: Aprovado");
                    System.Console.WriteLine ("----------------------------");
                } else {
                    System.Console.WriteLine ("Situação do aluno: Reprovado");
                    System.Console.WriteLine ("----------------------------");

                }
            }
        }
    }
}