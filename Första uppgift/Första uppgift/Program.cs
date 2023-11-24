using System;
namespace förstauppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord som ska upprepas 5 gånger.");

            string ord = Console.ReadLine();

            for (int i = 0; i < 9; i++)
            {
                Console.Write(ord);
            }
        }
    }
}