// See https://aka.ms/new-console-template for more information



using FactoryMethod.Messaging;

Console.WriteLine("Hello, World!");

var factory = new MessageFactory();
var creator = factory.GetCreator(MessageType.Sms);
var message = creator.CreateMessage();
message.Send("My message");
Console.ReadLine();