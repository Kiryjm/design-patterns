public interface IAsyncInit<T>
{
    Task<T> InitAsync();
}