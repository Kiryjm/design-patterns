// [Serializable]
public class Foo
{
    public uint Stuff;
    public string Whatever;
    public Bar Bar;

    public override string ToString()
    {
        return $"{nameof(Stuff)}: {Stuff}, " +
        $"{nameof(Whatever)}: {Whatever}, {Bar}";
    }
}