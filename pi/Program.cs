using System;

namespace pi
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100 ; i++)
            {
                System.Console.WriteLine(((i % 4 != 0) ? i.ToString() : "PI"));
            }
        }
    }
}