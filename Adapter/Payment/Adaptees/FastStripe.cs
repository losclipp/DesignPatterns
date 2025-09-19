namespace Adapter.Payment.Adaptees;

public sealed class FastStripe {
    public FastStripeResponse Charge(FastStripeRequest req)
    {
        if (req.Source == "000")
        {
            return new FastStripeResponse("", "failed");
        }
        return new FastStripeResponse("1241241234", "ok");
    }
}
public readonly record struct FastStripeRequest(decimal Amount, string Currency, string Source);
public readonly record struct FastStripeResponse(string Id, string Status); // "ok" | "failed"