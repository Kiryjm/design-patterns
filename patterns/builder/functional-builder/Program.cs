class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
{

}

internal class Program
{
     private static void Main(string[] args)
     {
          var me = Person.New
       .Called("Dmitri")
       .WorksAsA("Quant")
       .Born(DateTime.UtcNow)
       .Build();
          Console.WriteLine(me);
     }
}