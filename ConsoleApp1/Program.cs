namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Isik inimene1 = new Isik();
            //inimene1.Nimi = "Mati";
            //inimene1.Vanus = 35;
            //inimene1.Tervita(); // Väljund: Tere! Mina olen Mati...

            //Isik2 inimene1 = new Isik2();
            //inimene1.Nimi = "Mati";
            //inimene1.Sünniaasta = 2009;
            ///inimene1.Tervita();
            // Väljund: Tere! Mina olen Mati...

            Console.WriteLine("Kas te olete õpetaja või õpilane?");
            string answer = Console.ReadLine();
            if (answer == "Õpetaja")
            {
                Õpetaja õpetaja1 = new Õpetaja();
                Console.WriteLine("Mis teile tunnitasu?");
                double tunniastu = double.Parse(Console.ReadLine());
                õpetaja1.Tunnitasu = tunniastu;
                Console.WriteLine("Mis teile tunnidkuus?");
                int tunnidkuus = int.Parse(Console.ReadLine());
                õpetaja1.Tunnidkuus = tunnidkuus;
                Console.WriteLine("Teie palk: "+ õpetaja1.ArvutaPalk());
            }
            else if (answer == "Õpilane")
            {
                Õpilane õpilane1 = new Õpilane();
                Console.WriteLine("Mis on teie keskminehinne? ");
                double keskminehinne = double.Parse(Console.ReadLine());
                õpilane1.KeskmineHinne = keskminehinne;
                Console.WriteLine("Kui palju puudumised teil on? ");
                int puudumised = int.Parse(Console.ReadLine());
                õpilane1.Puudumised = puudumised;
                Console.WriteLine("Kas teil on sotstõend");
                string sotstõend = Console.ReadLine();
                if (sotstõend == "Jah")
                {
                    Console.WriteLine("Teie eritoestus on " + õpilane1.ArvutaPalk());
                }
                else
                {
                    Console.WriteLine("Teie põhitoestus on " + õpilane1.ArvutaPalk());

                }
            }
        }
    }
}
