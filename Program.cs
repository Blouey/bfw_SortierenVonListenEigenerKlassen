using System.Text;
using System.Text.Unicode;

namespace SortierenVonListenEigenerKlassen;

class Program
{
    static void utf8()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Clear();
    }

    static void Main(string[] args)
    {
        utf8();

        List<int> intList = new List<int>()
        {
            3,
            -5,
            55,
            20
        };
        intList.Add(100);
        intList.AddRange(new[] { 1, 2, 3 });

        List<Stadt> list = new List<Stadt>()
        {
            new Stadt() { Name = "Berlin", Einwohner = 3_769_495, Flaeche = 891.85 },
            new Stadt() { Name = "Hamburg", Einwohner = 1_899_160, Flaeche = 755.22 },
            new Stadt() { Name = "Essen", Einwohner = 582_760, Flaeche = 210.34 },
        };
        list.Add(new Stadt() { Name = "Krefeld", Einwohner = 227_020, Flaeche = 137.75 });
        
        
    }
}