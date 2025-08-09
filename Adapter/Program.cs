// See https://aka.ms/new-console-template for more information

using Adapter.Logger;


var loggerAdapter = new JsonLoggerAdapter(new LegacyJsonLogger());
loggerAdapter.Log(LogLevel.Error, "there is some error");
loggerAdapter.Log(LogLevel.Info, null);

Console.WriteLine("Hello, World!");