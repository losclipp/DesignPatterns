using Adapter.Payment.Adaptees;
using Adapter.Payment.Target;

namespace Adapter.Payment.Adaptors;

public class PayFriendAdapter : IPaymentGateway
{

    private readonly PayFriend _payFriend;
    
    public PayFriendAdapter(PayFriend payFriend)
    {
        _payFriend = payFriend;
    }
    public Task<string> ChargeAsync(decimal amount, string currency, string cardToken)
    {
        var tcs = new TaskCompletionSource<string>(TaskCreationOptions.RunContinuationsAsynchronously);
        string id = "";
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
        _payFriend.Pay((int)(amount * 100), currency, cardToken, (exception, s) =>
        {
            if (exception != null)
            {
                tcs.SetException(exception);
            }
            else if (s != null)
            {
                tcs.SetResult(s);
            }
            else
            {
                tcs.SetException(new InvalidOperationException("No id and no error from PayFriend."));
            }
        });
        
        return tcs.Task;
    }
}