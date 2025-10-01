namespace Adapter.HttpClient;

public sealed class LegacyHttp
{
    public void Get(string url, Action<int, string> onSuccess, Action<int, string> onFail)
    {
        if (string.IsNullOrEmpty(url))
        {
            onFail(400, "Bad Request");
            return;
        }
        
        Task.Delay(2000).Wait();
        if (url == "123")
        {
            onFail(500,"Internal Server Error");
        }
        else
        {
            onSuccess(200, "OK");
        }
    }
}