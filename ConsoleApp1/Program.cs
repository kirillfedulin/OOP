using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Õpetaja õpetaja1 = new Õpetaja
            {
                Nimi = "Arkadi",
                Sünniaasta = 2000,
                Aine = "Programmeerimine",
                Tunnitasu = 20,
                TunnidKuus = 80
            };
            õpetaja1.Õpeta();
            Console.WriteLine($"Palk: {õpetaja1.ArvutaPalk()}");

            Õpilane õpilane1 = new Õpilane
            {
                Nimi = "Martin",
                Sünniaasta = 2005,
                Kool = "TTHK",
                Klass = 12
            };

            õpilane1.Õpi();

            List<ITööline> palgasaajad = new List<ITööline>();
            Õpilane mati = new Õpilane();
            mati.Nimi = "Mati";
            mati.KeskmineHinne = 4.0;

            Õpilane k2adi = new Õpilane { Nimi = "Kadi", Klass = 11, Kool = "Kutsehariduskeskus", KeskmineHinne = 10, KasOnSotsTõend = false};
            Õpilane jü2ri = new Õpilane { Nimi = "Jüri", Klass = 12, Kool = "Kutsehariduskeskus", KeskmineHinne = 20, KasOnSotsTõend = false };

            Õpetaja anna = new Õpetaja { Nimi = "Kadi", Aine = "Python", Tunnitasu = 20, TunnidKuus = 60 };
            Õpetaja peeter = new Õpetaja { Nimi = "Jüri", Aine = "C#", Tunnitasu = 25, TunnidKuus = 60 };

            Õpetaja kadi = new Õpetaja { Nimi = "Kadi", Aine = "Python", Tunnitasu = 20, TunnidKuus = 60 };
            Õpetaja jüri = new Õpetaja { Nimi = "Jüri", Aine = "C#", Tunnitasu = 25, TunnidKuus = 60 };

            palgasaajad.AddRange(new ITööline[] { anna, peeter });

            Console.WriteLine("\n--- Väljamaksed ---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($" {tüüp}. Summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");
            }
        }
    }
}