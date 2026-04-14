using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //public class Isik
    //{
        //Omadused ehk väljad
        //public string Nimi;
        //public int Vanus;   

         //Tegevus ehk meetod
        //public void Tervita()
        //{
        //    Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana.");
        //}
    //}

    public class Isik
    {
        // Privaatne väli - otse ligi ei saa
        private int sünniaasta;

        // Avalik omadus (Property) automaatse get/set logikaga
        public string Nimi { get; set; }

        public void Ask()
        {
            Console.WriteLine("sissesta sinu sünniaasta: ");
            int answer = Convert.ToInt32(Console.ReadLine());
        }
        // Kontrollitud omadus
        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }
        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
            {
                Console.WriteLine("See on viga aasta");
            }
            else
            {
                Console.WriteLine($"{Vanus} aastat vana.");
            }
        }


        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => DateTime.Now.Year - sünniaasta;
    }
}
