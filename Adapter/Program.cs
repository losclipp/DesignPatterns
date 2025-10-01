// See https://aka.ms/new-console-template for more information

using Adapter.HttpClient;

var client = new AdaptedHttp();

try
{
    var result1 = await client.GetAsync("");
    Console.WriteLine(result1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var result2 = await client.GetAsync("asdfaf");
Console.WriteLine(result2);

try
{
    var result3 = await client.GetAsync("asdfaf", 100);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}



Console.WriteLine("Hello, World!");