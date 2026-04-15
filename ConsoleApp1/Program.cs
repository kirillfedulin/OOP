using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITööline> palgasaajad = new List<ITööline>();

            Õpetaja õpetaja1 = new Õpetaja
            {
                Nimi = "Arkadi",
                Sünniaasta = 2000,
                Aine = "Programmeerimine",
                Tunnitasu = 20,
                TunnidKuus = 80
            };

            Õpilane õpilane1 = new Õpilane
            {
                Nimi = "Martin",
                Sünniaasta = 2005,
                Kool = "TTHK",
                Klass = 12,
                KeskmineHinne = 4.5 
            };

            Õpilane mati = new Õpilane { Nimi = "Mati", KeskmineHinne = 4.0 };

            palgasaajad.Add(õpetaja1);
            palgasaajad.Add(õpilane1);
            palgasaajad.Add(mati);

            // 2. 
            Console.WriteLine("\n--- Väljamaksed ---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{tüüp}. Summa: {isik.ArvutaPalk()} eurot. Saaja: {((Isik)isik).Nimi}");
            }

            Koolihaldus minuKool = new Koolihaldus();

            minuKool.LisaInimene(õpetaja1);
            minuKool.LisaInimene(õpilane1);
            minuKool.LisaInimene(new Õpetaja { Nimi = "Kadi", Aine = "Python", Tunnitasu = 20, TunnidKuus = 60 });
            minuKool.LisaInimene(new Õpilane { Nimi = "Mari", Klass = 10, Staatus = Õppevorm.Päevane });

            Console.WriteLine("\n--- Kooli nimekiri ---");
            minuKool.KuvaKõik();
        }
    }
}