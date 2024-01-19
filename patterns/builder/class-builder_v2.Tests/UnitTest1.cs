namespace class_builder_v2.Tests;

public class Tests
{
    [TestFixture]
    public class FirstTestSuite
    {

        string classString__ = @"public class Person
{
  public string Name;
  public int Age;
}";
        private static string Preprocess(string s)
        {
            return s.Trim()
                // .Replace("\r\n", "\n") // for unix systems strings representation: row end for win - \r\n, unix - \n
                .TrimEnd('\r', '\n');
        }

        [Test]
        public void EmptyTest()
        {
            var cb = new CodeBuilder("Foo");
            Assert.That(Preprocess(cb.ToString()), Is.EqualTo("public class Foo\n{\n}"));
        }

        [Test]
        public void PersonTest()
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");
            Assert.That(Preprocess(cb.ToString()),
              Is.EqualTo(
                @"public class Person
{
  public string Name;
  public int Age;
}"
              ));
        }
    }
}