public class Foo : IAsyncInit<Foo>
{
    private string name;
    public Foo(string name)
    {
        this.name = name;
    }

    public async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    public static async Task<Foo> CreateAsync(string name)
    {
        var result = new Foo(name);
        return await result.InitAsync();
    }

    public override string ToString()
    {
        return $"name: {name}";
    }
}