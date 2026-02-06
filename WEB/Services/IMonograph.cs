namespace WEB.Services
{
    public interface IMonograph
    {
        Task<T> InvokeGetAsync<T>(string uri);
    }
}
