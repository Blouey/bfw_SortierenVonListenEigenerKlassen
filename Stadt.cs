namespace SortierenVonListenEigenerKlassen;

internal class Stadt
{
    public string Name { get; set; }
    public int Einwohner { get; set; }
    public double Flaeche { get; set; }
    public double EinwohnerProQuadratkilometer => Einwohner / Flaeche;
    
}