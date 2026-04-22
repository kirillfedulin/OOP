using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;

public class Koolihaldus
{
    // Kapseldatud list
    private List<Isik> inimesed = new List<Isik>();

    public void LisaInimene(List<Isik> uuedInimesed)
    {
        // Добавляем всех новых людей в основной список
        inimesed.AddRange(uuedInimesed);

        // Выводим информацию о КАЖДОМ добавленном человеке
        foreach (var isik in uuedInimesed)
        {
            // Предположим, у Isik есть свойство Nimi
            Console.WriteLine($"Lisati uus inimene: {isik}");
        }

        // Или просто выводим количество добавленных
        Console.WriteLine($"Kokku lisati {uuedInimesed.Count} uut inimest.");
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
    public void SalvestaFaili(string failinimi)
    {
        using (StreamWriter writer = new StreamWriter(failinimi))
        {
            foreach (Isik isik in inimesed)
            {
                writer.WriteLine(isik.Kirjelda());
            }
        }
    }


}
