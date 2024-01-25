[Serializable]
public class Address
{
    public string StreetAddress, City;
    public int Suite;

    public Address(string streetAddress, string city, int suite)
    {
        StreetAddress = streetAddress;
        City = city;
        Suite = suite;
    }

    public Address(Address other)
    {
        StreetAddress = other.StreetAddress;
        City = other.City;
        Suite = other.Suite;
    }

    public Address()
    {

    }
    public override string ToString()
    {
        return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(City)}: {City}, {nameof(Suite)}: {Suite}";
    }
}