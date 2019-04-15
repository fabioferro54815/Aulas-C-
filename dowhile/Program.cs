using System;

namespace dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int aumento = 0;

            do{
                Console.WriteLine("O vaor atual do aumento é de: "+aumento);
                aumento +=50;
            }while(aumento <500);
        }
    }
}
