using System;

namespace geradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desce uma palavra aí, meu compatriota!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[] PalavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; maxPalavrasUsuario > 0; i++)
            {
                PalavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0)
                {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma!");                    
                }else{
                    System.Console.WriteLine("Valeu jovi! Agora deixa comigo!");
                }
            }

            // string [,] matrizPalvras = {
            //                                 {"bode","","de","bexiga",""},
            //                                 {"abraça","caiu","","mexe","na"},
            //                                 {"pirambola","sorriu","","mandioca",""},
            //                                 {"eu","cabelo","eita","","com"},
            //                                 {"bonde","valter","baiano","","emos"}
            //                             };


            string [,] matrizPalvras = {
                                            {"Victor","João","Rafael","Pedro",""},
                                            {"andou","roubou","pescou","falou",""},
                                            {"de","da","no","com",""},
                                            {"carro","dona benta","rio","seu pai",""},
                                            {"sexta","domingo","ontem","as 3 da manhã",""}
                                        };

            for(int i = 0; i < matrizPalvras.GetLength(0); i++){
                for(int j = 0; j < matrizPalvras.GetLength(0); j++){
                    if("".Equals(matrizPalvras[i,j])){
                        matrizPalvras[i,j] = PalavrasUsuario[i];
                    }
                }
            }

            string frase = "";

            Random r = new Random();
            for (int i = 0; i < maxPalavrasFrase; i++) {
                frase += matrizPalvras[r.Next(matrizPalvras.GetLength(0)) , r.Next(matrizPalvras.GetLength(0))] + " ";
            }
            System.Console.WriteLine("Minha frase é: \n"+frase);
        }
    }
}