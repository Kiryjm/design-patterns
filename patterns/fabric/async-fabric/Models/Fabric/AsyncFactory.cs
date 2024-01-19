public static class AsyncFacfory
{
    public static async Task<T> Create<T>()
    where T : IAsyncInit<T>, new()
    {
        return await new T().InitAsync();
    }
}