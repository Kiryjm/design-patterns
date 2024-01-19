public class ClassEntity
{
    public string _className;
    public List<Tuple<string, string>> Types = new List<Tuple<string, string>>();

    public ClassEntity(string className)
    {
        _className = className;
    }
}