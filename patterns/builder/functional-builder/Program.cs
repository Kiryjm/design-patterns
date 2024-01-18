var b = new PersonBuilder();
var p = b.Called("Dmitri")
    .WorksAsA("Developer")
    .Build();
Console.WriteLine(p);