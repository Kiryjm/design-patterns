public class PersonFactory
{
    private int personId = 0;
    public Person person;

    public PersonFactory() { }

    public Person CreatePerson(string name)
    {
        return new Person(personId++, name);
    }
}