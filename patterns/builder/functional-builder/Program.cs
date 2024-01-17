// class SomeBuilder : PersonBirthDateBuilder<SomeBuilder>
// {

// }

var me = Person.New
     .Called("Dmitri")
     .WorksAsA("Quant")
     .Born(DateTime.UtcNow)
     .Build();
Console.WriteLine(me);