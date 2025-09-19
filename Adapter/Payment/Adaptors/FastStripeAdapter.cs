using Adapter.Payment.Adaptees;
using Adapter.Payment.Target;

namespace Adapter.Payment.Adaptors;

public class FastStripeAdapter : IPaymentGateway
{
    private readonly FastStripe _fastStripe;
    public FastStripeAdapter(FastStripe fastStripe)
    {
        _fastStripe = fastStripe;
    }
    public Task<string> ChargeAsync(decimal amount, string currency, string cardToken)
    {
        if (amount < 0.50m)
        {
            throw new ArgumentException("Amount must be greater than 0.5");
        }

        if (string.IsNullOrEmpty(currency))
        {
            throw new ArgumentException("Currency must be specified");
        }

        if (string.IsNullOrEmpty(cardToken))
        {
            throw new ArgumentException("Card token must be specified");
        }
        
        var request = new FastStripeRequest(amount, currency, cardToken);
        var response = _fastStripe.Charge(request);
        if (string.Equals(response.Status, "failed", StringComparison.OrdinalIgnoreCase))
        {
            throw new Exception("Charge failed");
        }

        if (string.Equals(response.Status, "ok", StringComparison.OrdinalIgnoreCase))
        {
            if (string.IsNullOrEmpty(response.Id))
            {
                throw new Exception("Payment ID is empty");
            }
            return Task.FromResult(response.Id);
        }
        else
        {
            throw new Exception("Unknown charge status");
        }
    }
}