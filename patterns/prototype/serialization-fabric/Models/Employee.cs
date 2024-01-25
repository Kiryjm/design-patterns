[Serializable]
public class Employee
{
    public string Name;
    public Address Address;

    public Employee(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public Employee(Employee other)
    {
        Name = other.Name;
        Address = new Address(other.Address);
    }

    public Employee()
    {

    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Address)}: {Address}";
    }
}