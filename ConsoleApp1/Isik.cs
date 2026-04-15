public abstract class Isik
{
    private int sünniaasta;
    public string Nimi { get; set; }

    public void Ask()
    {
        Console.Write("Sisesta oma sünniaasta: "); 
        if (int.TryParse(Console.ReadLine(), out int answer))
        {
            Sünniaasta = answer;
        }
    }

    public int Sünniaasta
    {
        get => sünniaasta;
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
            Console.WriteLine("Andmed on puudu!");
        }
        else
        {
            Console.WriteLine($"Tere! Mina olen {Nimi} и мне {Vanus} лет.");
        }
    }

    public int Vanus => DateTime.Now.Year - sünniaasta;
    public abstract void Kirjelda();
}