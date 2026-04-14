using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Õpetaja : Isik
        {
            public string Aine { get; set; }

            public void Õpeta()
            {
                Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
            }
        }

        // Õpilane pärib klassist Isik
        public class Õpilane : Isik
        {
            public string Kool { get; set; }
            public int Klass { get; set; }

            public void Õpi()
            {
                Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
            }
        }
    }
