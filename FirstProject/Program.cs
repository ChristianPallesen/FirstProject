using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hej = "Hello World.";
            Console.WriteLine(Hej);



            Console.WriteLine("Skriv dit fornavn:");

            string fornavn = Console.ReadLine();

            Console.WriteLine("Skriv dit efternavn:");

            string efternavn = Console.ReadLine();

            Console.WriteLine("Dit navn er : " + fornavn + " " + efternavn);

        }
    }
}
