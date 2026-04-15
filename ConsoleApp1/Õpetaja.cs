using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ConsoleApp1
{
        public class Õpetaja : Isik, ITööline
        {
            public string Aine { get; set; }
            public string Nimi { get; set; }
            public double Tunnitasu { get; set; }
            public int Tunnidkuus { get; set; }

            public void Õpeta()
            {
                Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
            }
            
        public double ArvutaPalk()
            {
                return Tunnitasu * Tunnidkuus;
            }
        }


}
