namespace person_fabric.Tests;

[TestFixture]
public class CreateMultiplePersonsTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test()
    {
        var pf = new PersonFactory();
        var p1 = pf.CreatePerson("Dimitri");
        var p2 = pf.CreatePerson("Ned");
        Assert.That(p1.Id, Is.EqualTo(0));
        Assert.That(p1.Name, Is.EqualTo("Dimitri"));

        Assert.That(p2.Id, Is.EqualTo(1));
        Assert.That(p2.Name, Is.EqualTo("Ned"));
    }
}