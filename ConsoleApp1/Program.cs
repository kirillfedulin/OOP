using ConsoleApp1;
using ConsoleApp1.ulesanne1;
using System.Net.WebSockets;

namespace OOP_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2000;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            Koolihaldus minuKool = new Koolihaldus();
            List<ITööline> palgasaajad = new List<ITööline>();
            Random rnd = new Random();
            ITööline[] toolised = new ITööline[2]
            {
                new Õpilane(),
                new Õpetaja()
            };

            //Õpetajad
            string[] õpetajaNimed = { "Marina", "Aleksei", "Katrin", "Dmitri", "Liisa" };
            int[] õpetajaSünniaastad = { 1975, 1982, 1990, 1995, 1988 };
            string[] ained = { "programmeerimine", "matemaatika", "füüsika", "keemia", "eesti keel" };
            double[] tunnitasud = { 13.8, 15.0, 12.5, 14.2, 16.0 };
            int[] tunnidKuus = { 120, 130, 140, 150, 160 };

            //Õpilased
            string[] õpilasNimed = { "Yaroslav", "Anna", "Peeter", "Maria", "Ivan" };
            int[] õpilasSünniaastad = { 2005, 2006, 2007, 2008, 2009 };
            string[] koolid = { "TTHK", "Gustav Adolfi Gümnaasium", "Tallinna Reaalkool" };
            int[] klassid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int[] puudumised = { 0, 5, 10, 13, 20 };

            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm)); // teeb list

            for (int i = 0; i < 5; i++)
            {

                int randomIsik = rnd.Next(0, 2);
                var tooline = toolised[randomIsik];
                switch (tooline)
                {
                    case Õpilane:

                        Õpilane õpilane = new Õpilane();
                        õpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        õpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        õpilane.Kool = koolid[rnd.Next(1, 3)];
                        õpilane.Klass = klassid[rnd.Next(1, 12)];
                        õpilane.KeskmineHinne = rnd.NextDouble() * 5;
                        õpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        õpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        õpilane.Kirjelda();
                        õpilane.Õpi();
                        õpilane.ArvutaPalk();
                        minuKool.LisaInimene(õpilane);
                        palgasaajad.Add(õpilane);
                        Console.WriteLine("===================================================");
                        break;


                    case Õpetaja:

                        Õpetaja õpetaja = new Õpetaja();
                        õpetaja.Nimi = õpetajaNimed[rnd.Next(1, 5)];
                        õpetaja.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
                        õpetaja.Aine = ained[rnd.Next(1, 5)];
                        õpetaja.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
                        õpetaja.TunnidKuus = tunnidKuus[rnd.Next(1, 5)];
                        palgasaajad.Add(õpetaja);
                        õpetaja.Kirjelda();
                        õpetaja.Õpeta();
                        minuKool.LisaInimene(õpetaja);
                        Console.WriteLine("===================================================");
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine("---VÄLJAMAKSED---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{tüüp}. summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");

            }

            Console.WriteLine("================MINU KOOL==================");
            minuKool.KuvaKõik();
        }
    }
}