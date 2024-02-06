Foo foo = new Foo
{
    Stuff = 42,
    Whatever = "abc",
    Bar = new Bar { Value = 321 }
};

var foo2 = foo.DeepGroBufClone();
var foo3 = foo.DeepCopyXml();
foo2.Whatever = "brg";
// foo2.Bar.Value = 1000;
foo3.Whatever = "xml";
foo3.Bar.Value = 2000;

Console.WriteLine(foo);
Console.WriteLine(foo2);
Console.WriteLine(foo3);