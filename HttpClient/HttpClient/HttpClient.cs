namespace HttpClient;

public interface IHttpClient
{
    public Task<string> GetMessage(string employeeName);
}

public class HttpClient : IHttpClient
{
    public Task<string> GetMessage(string employeeName)
    {
        return Task.FromResult($"Hello {employeeName}!");
    }
}
