// See https://aka.ms/new-console-template for more information


using Builder.HTML;

var builder = new HTMLBuilder();

var query = builder
    .AddHeader(1, "This is header")
    .AddParagraph("Some content.")
    .AddImage("""https://shorthand.com/the-craft/raster-images/assets/5kVrMqC0wp/sh-unsplash_5qt09yibrok-4096x2731.jpeg""", "Photo")
    .AddHeader(6, "This is header smaller")
    .Build();


Console.WriteLine(query);

Console.WriteLine("Hello, World!");