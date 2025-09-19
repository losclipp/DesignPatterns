namespace Adapter.Payment.Adaptees;

public sealed class PayFriend {
    // cb: (Exception? error, string? id)
    public void Pay(int sumInCents, string isoCurrency, string token, Action<Exception?, string?> cb)
    {
        if (token == "000")
        {
            cb(new Exception("invalid token"), null);
        }
        else
        {
            cb(null, "124124");
        }
    }
}