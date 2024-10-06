
Vare nyVare = new Vare();
nyVare.Navn = "Banan";
nyVare.Pris = 10;

Console.WriteLine(nyVare.Navn);
Console.WriteLine(nyVare.Pris);

Console.WriteLine(nyVare.PrisMedMoms());

class Vare
{
    private string _navn;

    public string Navn
    {
        get { Console.WriteLine("Navn aflæst."); return _navn; }
        set { Console.WriteLine($"Navn ændret til {value}"); _navn = value; }
    }

    private double _pris;

    public double Pris
    {
        get { Console.WriteLine("Pris aflæst."); return _pris; }
        set { Console.WriteLine($"Pris ændret til {value}"); _pris = value; }
    }

    public Vare()
    {
        _navn = "Ukendt";
        _pris = 0;
    }

    public Vare(string navn, double pris)
    {
        _navn = navn;
        _pris = pris;
    }

    public double PrisMedMoms()
    {
        return _pris * 1.25;
    }
}