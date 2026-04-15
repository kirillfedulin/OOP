namespace ConsoleApp1
{
    public class Õpilane : Isik, ITööline
    {
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; }
        public int Puudumised { get; set; } = 0;
        public bool KasOnSotsTõend { get; set; } = false;
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Toetus;
        public Õppevorm Staatus { get; set; }

        // 1. ОБЯЗАТЕЛЬНО: Реализация абстрактного метода из Isik
        public override void Kirjelda()
        {
            Console.WriteLine($"Õpilane {Nimi} õpib koolis {Kool}, {Klass}. klassis.");
        }

        public void Õpi()
        {
            // Убрали дублирование, объединили в одну логичную строку
            Console.WriteLine($"{Nimi} õpib {Kool}is {Klass}. klassis. Õppevorm: {Staatus}");
        }

        public double ArvutaPalk()
        {
            double põhitoestus = 0;
            double eritoestus = 0;

            if (KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                põhitoestus = 60;
            }

            if (KasOnSotsTõend)
            {
                eritoestus = 120;
            }

            return põhitoestus + eritoestus;
        }
    }
}