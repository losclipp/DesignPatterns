namespace Adapter.Payment.Target;

public interface IPaymentGateway
{
    Task<string> ChargeAsync(decimal amount, string currency, string cardToken);
}