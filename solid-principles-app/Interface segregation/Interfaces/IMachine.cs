public interface IMachine
{
    void Print(Document d)
    {

    }
    void Fax(Document d)
    {

    }

    // not good approach as we indicate this method as old
    // and it means it was supported in former times
    // but the truth is this method actually was never supported
    [Obsolete("Not supported", true)]
    void Scan(Document d)
    {

    }
}