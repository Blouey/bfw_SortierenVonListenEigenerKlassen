namespace SortierenVonListenEigenerKlassen;

internal class SorterNameDesc:IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Name.CompareTo(y.Name) * -1;
    }
}

internal class SorterFlaecheAsc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Flaeche.CompareTo(y.Flaeche);
    }
}

internal class SorterFlaecheDesc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Flaeche.CompareTo(y.Flaeche) *-1;
    }
}


internal class SorterEinwohnerAsc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Einwohner.CompareTo(y.Einwohner);
    }
}


internal class SorterEinwohnerDesc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Einwohner.CompareTo(y.Einwohner) *-1;
    }
}


internal class SorterEinwohnerProFlaecheAsc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.EinwohnerProQuadratkilometer.CompareTo(y.EinwohnerProQuadratkilometer);
    }
}

internal class SorterEinwohnerProFlaecheDesc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.EinwohnerProQuadratkilometer.CompareTo(y.EinwohnerProQuadratkilometer) *-1;
    }
}

internal class SorterNameLengthAsc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Name.Length.CompareTo(y.Name.Length);
    }
}

internal class SorterNameLengthDesc : IComparer<Stadt>
{
    public int Compare(Stadt? x, Stadt? y)
    {
        return x.Name.Length.CompareTo(y.Name.Length) *-1;
    }
}
