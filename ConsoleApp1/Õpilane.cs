using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Õpilane : Isik, ITööline
    {
        // Õpilane pärib klassist Isik
        public string Kool { get; set; }
        public int Klass { get; set; }
        public double KeskmineHinne { get; set; } //põhitoestus 60eur
        public int Puudumised { get; set; } = 0; //põhitoestus
        public bool KasOnSotsTõend { get; set; } = false; //eritoestus1 12eur
         
        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }

        public double ArvutaPalk()
        {
            double põhitoestus = 0; 
            double eritoestus = 0;

            if (KeskmineHinne >= 3.8 && Puudumised <= 30)
            {
                põhitoestus += 60;
            }
            if (KasOnSotsTõend)
            {
                eritoestus += 120;
            }

            return põhitoestus + eritoestus;
        }

    }
}
