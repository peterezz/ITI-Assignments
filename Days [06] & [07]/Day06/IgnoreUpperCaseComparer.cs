internal class IgnoreUpperCaseComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return x.ToLower().CompareTo(y.ToLower());
    }
}