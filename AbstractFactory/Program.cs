// See https://aka.ms/new-console-template for more information

using AbstractFactory.Gui.Base;

Console.WriteLine("Hello, World!");

var factory = CreateFactory.GetFactory(OsType.Mac);

var button = factory.CreateButton();
var checkBox = factory.CreateCheckBox();
var textBox = factory.CreateTextField();

button.Render();
checkBox.Render();
textBox.Render();

Console.ReadLine();