using System;

class Program
{
    static void Main()
    {
        string jelszo;

        while (true)
        {
            Console.Write("Kérem, adja meg a jelszót: ");
            jelszo = Console.ReadLine();

            if (jelszo.Length >= 8 &&
                jelszo.IndexOfAny("0123456789".ToCharArray()) >= 0 &&
                jelszo.IndexOfAny("ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray()) >= 0)
            {
                Console.WriteLine("Jelszó elfogadva!");
                break; 
            }
            else
            {
                Console.WriteLine("A jelszó nem felel meg a kritériumoknak. Kérjük, próbálkozzon újra.");
            }
        }
    }
}
