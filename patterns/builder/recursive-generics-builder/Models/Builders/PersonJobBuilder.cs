public class PersonJobBuilder<SELF>
    : PersonInfoBuilder</*PersonJobBuilder<SELF>*/SELF>
    where SELF : PersonJobBuilder<SELF>
{
  public SELF WorksAsA(string position)
  {
    person.Position = position;
    return (SELF)this;
  }
}
