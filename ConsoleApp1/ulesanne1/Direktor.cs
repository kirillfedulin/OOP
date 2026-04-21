using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.ulesanne1
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }

        public override double ArvutaPalk()
        {
            return base.ArvutaPalk() + Lisatasu;
        }
    }
}