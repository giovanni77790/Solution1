using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcolo;
            Console.WriteLine("inserisci il primo valore:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il secondo valore:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il numero di bit:");
            int risposta = Convert.ToInt32(Console.ReadLine());

            if (risposta == 1)
            {
                calcolo = ((n1 * n2) / 8) / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if ( risposta == 8)
            {
                calcolo = (n1 * n2) / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if ( risposta == 16)
            {
                calcolo = (n1 * n2) * 2 / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else if ( risposta == 24)
            {
                calcolo = (n1 * n2) * 3 / 1024;
                Console.WriteLine($"L'immagine pesa {calcolo}KB");
            }
            else
            {
                Console.WriteLine("vale solo per 1, 8, 16, 24 bit");
            }
        }
    }
}
