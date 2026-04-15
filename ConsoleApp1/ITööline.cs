using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum TööTüüp
    {
        Palk,
        Toetus
    }
    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }
    internal interface ITööline
    {
        TööTüüp VäljamakseTüüp { get; set; }
        double ArvutaPalk(); //Meetod, mis arvutab tööline palga

    }

}
