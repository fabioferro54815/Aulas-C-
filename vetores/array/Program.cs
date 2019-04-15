using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};
            int impares = 0;

            for(int i = 0; i < numeros.Length ; i++){
               if(numeros[i] % 2 !=0){
                impares+=1;
               }
            }
            System.Console.WriteLine($"A quantidade de ímpares é: {impares}");
        }
    }
}