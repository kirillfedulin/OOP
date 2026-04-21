using ConsoleApp1;

public class Õpetaja : Isik, ITööline
{
    public string Aine { get; set; }
    // УДАЛИЛИ Nimi отсюда, так как он наследуется от Isik

    public double Tunnitasu { get; set; }
    public int TunnidKuus { get; set; }
    public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk;

    // ОБЯЗАТЕЛЬНО: Реализация абстрактного метода
    public override void Kirjelda()
    {
        Console.WriteLine($"Õpetaja {Nimi} õpetab ainet {Aine}.");
    }

    // Реализация метода интерфейса
    public virtual double ArvutaPalk()
    {
        return Tunnitasu * TunnidKuus;
    }

    public void Õpeta()
    {
        Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
    }
}
    
