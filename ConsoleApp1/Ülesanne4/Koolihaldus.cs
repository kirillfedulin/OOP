using ConsoleApp1;
using System;
using System.Collections.Generic;

public class Koolihaldus
{
    // Kapseldatud list
    private List<Isik> inimesed = new List<Isik>();

    public void LisaInimene(Isik isik)
    {
        inimesed.Add(isik);
    }

    // ... (eelnevad meetodid LisaInimene, KuvaKõik) ...

    // 1. Otsing nime järgi (võtab vastu stringi)
    public void Otsi(string otsitavNimi)
    {
        Console.WriteLine($"\nOtsime nime: {otsitavNimi}");
        foreach (var isik in inimesed)
        {
            if (isik.Nimi.Contains(otsitavNimi)) isik.Kirjelda();
        }
    }

    // 2. Otsing nimekirjas numbri/sünniaasta järgi (sama nimi, aga võtab vastu int)
    public void Otsi(int sünniaasta)
    {
        Console.WriteLine($"\nOtsime kedagi, kes on sündinud aastal: {sünniaasta}");

        foreach (var isik in inimesed)
        {
            if (isik.Sünniaasta == sünniaasta)
            {
                isik.Kirjelda();
            }
        }
    }


}
