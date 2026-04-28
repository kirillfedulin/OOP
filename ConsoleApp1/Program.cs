using ConsoleApp1;
using ConsoleApp1.ulesanne1;
using ConsoleApp1.Ülesanne3;
using System.Net.WebSockets;
using System.Xml;

namespace ConsoleApp1
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
            ITööline[] toolised = new ITööline[3]
            {
                new Õpilane(),
                new Õpetaja(),
                new Üliõpilane()
            };

            //Õpetajad
            string[] õpetajaNimed = { "Marina", "Aleksei", "Katrin", "Dmitri", "Liisa" };
            int[] õpetajaSünniaastad = { 1975, 1982, 1990, 1995, 2000 };
            string[] ained = { "programmeerimine", "matemaatika", "füüsika", "keemia", "eesti keel" };
            double[] tunnitasud = { 13.8, 15.0, 12.5, 14.2, 16.0 };
            int[] tunnidKuus = { 120, 130, 140, 150, 160 };
            string[] hinne = { "1", "2", "3", "4", "5" };
            string[] kursused = { "IKTpv_1 (TAR)", "TITpv23", "IKTpv_2 (ITS)", "LOGITpe23", "ROOpv24" };


            //Õpilased
            string[] õpilasNimed = { "Yaroslav", "Anna", "Peeter", "Maria", "Ivan" };
            int[] õpilasSünniaastad = { 2005, 2006, 2007, 2008, 2009 };
            string[] koolid = { "TTHK", "Gustav Adolfi Gümnaasium", "Tallinna Reaalkool" };
            int[] klassid = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] puudumised = { 0, 5, 10, 13, 20 };

            //Üliõpilane
            string[] kuurs = { "1", "2", "3", "4", "5" };

            //Direktor
            double[] lisatasu = { 100, 200, 300, 400, 500 };


            Õppevorm[] vormid = (Õppevorm[])Enum.GetValues(typeof(Õppevorm)); // teeb list õppevormist

            Console.WriteLine("=================DIREKTOR==================");
            Direktor direktor = new Direktor();
            direktor.Nimi = õpetajaNimed[rnd.Next(1, 5)];
            direktor.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, 5)];
            direktor.Tunnitasu = tunnitasud[rnd.Next(1, 5)];
            direktor.TunnidKuus = tunnidKuus[rnd.Next(1, 5)];
            direktor.Lisatasu = lisatasu[rnd.Next(1, 5)];
            palgasaajad.Add(direktor);
            direktor.ArvutaPalk();
            direktor.Kirjelda();



            for (int i = 0; i < 20; i++)
            {

                int randomIsik = rnd.Next(0, 3);
                var tooline = toolised[randomIsik];
                switch (tooline)
                {
                    case Üliõpilane:
                        Console.WriteLine("=================ÜLIÕPILANE==================");
                        Üliõpilane üliõpilane = new Üliõpilane();
                        üliõpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                        üliõpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                        üliõpilane.Kool = koolid[rnd.Next(1, 3)];
                        üliõpilane.Kuurs = kuurs[rnd.Next(1, 5)];
                        üliõpilane.KeskmineHinne = rnd.NextDouble() * 5;
                        üliõpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                        üliõpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        üliõpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        üliõpilane.Kirjelda();
                        üliõpilane.Õpi();
                        üliõpilane.ArvutaPalk();
                        palgasaajad.Add(üliõpilane);

                        break;


                    case Õpilane:
                        Console.WriteLine("=================ÕPILANE==================");
                        Õpilane õpilane = new Õpilane();
                        õpilane.Nimi = õpilasNimed[rnd.Next(1, õpilasNimed.Length)];
                        õpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, õpilasSünniaastad.Length)];
                        õpilane.Kool = koolid[rnd.Next(1, koolid.Length)];
                        õpilane.Klass = klassid[rnd.Next(1, klassid.Length)];
                        õpilane.Keskminehinne = rnd.NextDouble() * 5;
                        õpilane.Puudumised = puudumised[rnd.Next(1, puudumised.Length)];
                        õpilane.SotsiaalAmet = rnd.Next(2) == 0; // random bool
                        õpilane.Staatus = vormid[rnd.Next(vormid.Length)];

                        õpilane.Kirjelda();
                        õpilane.Õpi();
                        õpilane.ArvutaPalk();
                        minuKool.LisaInimene(õpilane);
                        palgasaajad.Add(õpilane);

                        break;





                    case Õpetaja:
                        Console.WriteLine("=================ÕPETAJA==================");
                        Õpetaja õpetaja = new Õpetaja();
                        õpetaja.Nimi = õpetajaNimed[rnd.Next(1, õpetajaNimed.Length)];
                        õpetaja.Sünniaasta = õpetajaSünniaastad[rnd.Next(1, õpetajaSünniaastad.Length)];
                        õpetaja.Aine = ained[rnd.Next(1, ained.Length)];
                        õpetaja.Tunnitasu = tunnitasud[rnd.Next(1, tunnitasud.Length)];
                        õpetaja.TunnidKuus = tunnidKuus[rnd.Next(1, tunnidKuus.Length)];
                        Kursus kursus = new Kursus(kursused[rnd.Next(0, kursused.Length)], õpetaja);
                        kursus.KuvaInfo();
                        palgasaajad.Add(õpetaja);
                        õpetaja.Kirjelda();
                        õpetaja.Õpeta();
                        õpetaja.Hinda(hinne[rnd.Next(1, 5)]);
                        minuKool.LisaInimene(õpetaja);

                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("===================KONSTRUKTORIGA======================");
            Õpilane õpilane1 = new Õpilane(õpilasNimed[rnd.Next(1, 5)],
                koolid[rnd.Next(1, 3)],
                klassid[rnd.Next(1, 12)],
                vormid[rnd.Next(vormid.Length)]);

            õpilane1.Kirjelda();
            Console.WriteLine("=======================================================");
            Console.WriteLine("---VÄLJAMAKSED---");
            foreach (ITööline isik in palgasaajad)
            {
                string tüüp = isik.VäljamakseTüüp.ToString();
                Console.WriteLine($"{tüüp}. summa: {isik.ArvutaPalk()} eurot. {((Isik)isik).Nimi}le");

            }

            List<Isik> uuedInimesed = new List<Isik>();

            Console.WriteLine("Võetsi vastu nii palju inimesed: ");

            for (int i = 0; i < rnd.Next(10, 30); i++)
            {

                Õpilane õpilane = new Õpilane();
                õpilane.Nimi = õpilasNimed[rnd.Next(1, 5)];
                õpilane.Sünniaasta = õpilasSünniaastad[rnd.Next(1, 5)];
                õpilane.Kool = koolid[rnd.Next(1, 3)];
                õpilane.Klass = klassid[rnd.Next(1, 12)];
                õpilane.KeskmineHinne = rnd.NextDouble() * 5;
                õpilane.Puudumised = puudumised[rnd.Next(1, 5)];
                õpilane.SotsiaalAmet = rnd.Next(2) == 0;
                õpilane.Staatus = vormid[rnd.Next(vormid.Length)];
                õpilane.Kirjelda();
                uuedInimesed.Add(õpilane);

            }




            Console.WriteLine("================MINU KOOL==================");
            Console.WriteLine($"Koolis on hetkel süsteemis registreeritud {Isik.InimesteKoguarv} isikut.");
            minuKool.KuvaKõik();
            Console.WriteLine("==============UUED INIMESED=============");
            minuKool.LisaInimene(uuedInimesed);
            Console.WriteLine("=============LISAMISE PÄRAST===============");
            minuKool.KuvaKõik();
            Console.WriteLine("=============AINULT ÕPILASED===============");
            minuKool.KuvaAinultÕpilased();

            Console.Write("Kas sa tahad ostida keegi? jah/ei: ");
            string valik = Console.ReadLine();
            try
            {

                if (valik == "jah")
                {
                    Console.Write("sisesta nimi või sünniaasta: ");
                    string Andmed = Console.ReadLine();

                    if (int.TryParse(Andmed, out int sünniaasta))
                    {

                        minuKool.Otsi(sünniaasta);

                    }
                    else
                    {
                        minuKool.Otsi(Andmed);

                    }

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Ei leitud mitte keegi");
            }

            Console.WriteLine("kuhu sa tahad salvesta kõik andmed koolist(pole .txt):   ");
            string failinimi = Console.ReadLine();
            minuKool.SalvestaFaili(failinimi);






            //Õpetaja õpetaja1 = new Õpetaja();
            //õpetaja1.Nimi = "Marina";
            //õpetaja1.Sünniaasta = 1995;
            //õpetaja1.Aine = "programmeerimine";
            //õpetaja1.Kirjelda();
            //õpetaja1.Õpeta();
            //õpetaja1.Tunnitasu = 13.8;
            //õpetaja1.Tunnidkuus = 140;
            //õpetaja1.ArvutaPalk();
            //Console.WriteLine("===================================================");
            //Õpilane õpilane1 = new Õpilane();
            //õpilane1.Nimi = "Yaroslav";
            //õpilane1.Sünniaasta = 2008;
            //õpilane1.Kool = "TTHK";
            //õpilane1.Klass = 1;
            //õpilane1.Kirjelda();
            //õpilane1.Õpi();
            //õpilane1.Keskminehinne = 4;
            //õpilane1.Puudumised = 13;
            //õpilane1.SotsiaalAmet = true;
            //õpilane1.ArvutaPalk();
        }
    }
}