namespace Adapter.HttpClient;

public class AdaptedHttp : IHttpClient
{
    private readonly LegacyHttp _legacyHttp = new LegacyHttp();
    public Task<HttpResult> GetAsync(string url, int? timeoutMs = null)
    {
        var tcs = new TaskCompletionSource<HttpResult>(TaskCreationOptions.RunContinuationsAsynchronously);
        if (timeoutMs.HasValue && timeoutMs.Value > 0)
        {
            var cts = new CancellationTokenSource(timeoutMs.Value);
            var reg = cts.Token.Register(() => tcs.TrySetException( new TimeoutException("Request Timeout expired")));
            _ = tcs.Task.ContinueWith(_ =>
            {
                reg.Dispose();
                cts.Dispose();
            }, TaskScheduler.Default);
        }
        
        _legacyHttp.Get(
            url,
            onSuccess: (status, body) =>
            {
                if (status == 204)
                {
                    body = string.Empty;
                }
                tcs.TrySetResult((new HttpResult(status, body)));
            },
            onFail: (status, msg) =>
            {
                if (status == 400)
                {
                    tcs.TrySetResult(new HttpResult(status, msg));

                }
                else
                {
                    tcs.TrySetException(new InvalidOperationException(msg));
                }
            });

        return tcs.Task;
    }
}