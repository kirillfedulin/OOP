using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Ülesanne3
{
    public class Üliõpilane : Õpilane
    {
        public string Kursus { get; set; }
        public string Oppevorm { get; set; }
        public string Eriala { get; set; }

        public override void Kirjelda()
        {
            base.Kirjelda();
            Console.WriteLine($"Kursus: {Kursus}, Õppevorm: {Oppevorm}, Eriala: {Eriala}");
        }
    }
}

