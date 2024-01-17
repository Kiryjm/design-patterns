public class PersonBuilder // facade 
  {
    // the object we're going to build
    protected Person person;

    public PersonBuilder() => person = new Person();
    protected PersonBuilder(Person person) => this.person = person;

    public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
    public PersonJobBuilder Works => new PersonJobBuilder(person);
  
    public static implicit operator Person(PersonBuilder pb)
    {
      return pb.person;
    }
  }