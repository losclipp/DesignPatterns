namespace Adapter.HttpClient;

public interface IHttpClient
{
    Task<HttpResult> GetAsync(string url, int? timeoutMs = null);
}

public readonly record struct HttpResult(int Status, string Body);