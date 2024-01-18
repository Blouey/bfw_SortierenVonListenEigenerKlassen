namespace SortierenVonListenEigenerKlassen;

internal class Stadt:IComparable<Stadt>
{
    public string Name { get; set; }
    public int Einwohner { get; set; } // Anzahl der Einwohner
    public double Flaeche { get; set; } // in Quadratkilometer
    public double EinwohnerProQuadratkilometer => Einwohner / Flaeche;
    
    public int CompareTo(Stadt? other)
    {
        /*
        if(Flaeche.CompareTo(other?.Flaeche) > 0)
            return 1;
        if(Flaeche.CompareTo(other?.Flaeche) < 0)
            return -1;
        return 0;
        */
        return Name.CompareTo(other.Name);
    }
}