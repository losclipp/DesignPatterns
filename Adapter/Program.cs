// See https://aka.ms/new-console-template for more information

using Adapter.Payment.Adaptees;
using Adapter.Payment.Adaptors;

var farStripeAdapter = new FastStripeAdapter(new FastStripe());
try
{
    Console.WriteLine($"result id1: {(await farStripeAdapter.ChargeAsync(0.4m, "USD", "1241241234"))}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    Console.WriteLine($"result id2: {(await farStripeAdapter.ChargeAsync(1m, "USD", "000"))}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.WriteLine( $"result id3: {(await farStripeAdapter.ChargeAsync(1m, "USD", "1423344"))}");

var payFriendAdapter = new PayFriendAdapter(new PayFriend());

try
{
    Console.WriteLine($"result id4: {(await payFriendAdapter.ChargeAsync(0.4m, "USD", "1241241234"))}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

try
{
    Console.WriteLine($"result id5: {(await payFriendAdapter.ChargeAsync(1m, "USD", "000"))}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.WriteLine( $"result id6: {(await payFriendAdapter.ChargeAsync(1m, "USD", "1423344"))}");


Console.WriteLine("Hello, World!");