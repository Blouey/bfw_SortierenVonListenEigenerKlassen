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

        List<int> intList = new List<int>() { 3, -5, 55, 20 };
        intList.Add(100);
        intList.AddRange(new[] { 1, 2, 3 });

        List<Stadt> list = new List<Stadt>()
        {
            new Stadt() { Name = "Essen", Einwohner = 582_760, Flaeche = 210.34 },
            new Stadt() { Name = "Berlin", Einwohner = 3_769_495, Flaeche = 891.85 },
            new Stadt() { Name = "Hamburg", Einwohner = 1_899_160, Flaeche = 755.22 },
        };
        list.Add(new Stadt() { Name = "Krefeld", Einwohner = 227_020, Flaeche = 137.75 });
/*
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nAusgangsliste: ");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Red;
        list.Sort();
        Console.WriteLine("\nStandardSorter:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Cyan;
        list.Sort(new SorterNameDesc());
        Console.WriteLine("\nSorterNameDesc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Gray;
        list.Sort(new SorterEinwohnerAsc());
        Console.WriteLine("\nSorterEinwohnerAsc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        list.Sort(new SorterEinwohnerDesc());
        Console.WriteLine("\nSorterEinwohnerDesc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        list.Sort(new SorterFlaecheAsc());
        Console.WriteLine("\nSorterFlaecheAsc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.Green;
        list.Sort(new SorterFlaecheDesc());
        Console.WriteLine("\nSorterFlaecheDesc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.");
        }
        
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        list.Sort(new SorterEinwohnerProFlaecheAsc());
        Console.WriteLine("\nSorterEinwohnerProFlaecheAsc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer. Einwohner/km²: {stadt.EinwohnerProQuadratkilometer:F2}");
        }
        
        Console.ForegroundColor = ConsoleColor.DarkGray;
        list.Sort(new SorterEinwohnerProFlaecheDesc());
        Console.WriteLine("\nSorterEinwohnerProFlaecheDesc:");
        foreach (Stadt stadt in list)
        {
            Console.WriteLine($"{stadt.Name} hat {stadt.Einwohner:N0} Einwohner und eine Fläche von {stadt.Flaeche} Quadratkilometer.Einwohner/km²: {stadt.EinwohnerProQuadratkilometer:F2}");
        }*/
        //##################################################
        /*
         * Stadt mit den meisten Einwohnern
         *  "     "   der größten Fäche
         *  "     "   dem längsten Stadtnamen
         */

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        
        list.Sort(new SorterEinwohnerDesc());
        Console.WriteLine($"{list[0].Name} hat mit eine Anzahl von {list[0].Einwohner:N0} die meisten Einwohner.");
        list.Sort(new SorterFlaecheDesc());
        Console.WriteLine($"{list[0].Name} hat mit einer Fläche von {list[0].Flaeche} Quadratkilometern die größte Fläche.");
        list.Sort(new SorterNameLengthDesc());
        Console.WriteLine($"{list[0].Name} hat mit einer Länge von {list[0].Name.Length} Zeichen den längsten Namen.");
        Console.ResetColor();
        






    }
}