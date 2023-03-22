using System.Diagnostics.CodeAnalysis;

internal class ArrEqualityComparer : IEqualityComparer<string>
{

    public bool Equals(string? x, string? y)
    {
        string resultx = String.Join("", x.ToLower().OrderBy(chr => chr));
        string resulty = String.Join("", y.ToLower().OrderBy(chr => chr));
        return resultx == resulty;
    }
    public int GetHashCode([DisallowNull] string obj)
    {

        return base.GetHashCode();
    }
   
}