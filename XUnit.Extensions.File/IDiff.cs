namespace XUnit
{
    public interface IDiff
    {
        string Generate(string one, string two, Diff.Options options = null);
    }
}
