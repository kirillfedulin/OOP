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

            Õpetaja õpetaja1 = new Õpetaja();
            õpetaja1.Sünniaasta = 1875;
            õpetaja1.Aine = "Programitimine";
            õpetaja1.Õpeta();
            Õpilane õpilane1 = new Õpilane();
            õpilane1.Sünniaasta = 2009;
            õpilane1.Kool = "TheSchool";
            õpilane1.Klass = 9;
            õpilane1.Õpi();


        }
    }
}
