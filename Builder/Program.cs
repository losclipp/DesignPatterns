// See https://aka.ms/new-console-template for more information


using Builder.SQL;
using Builder.User;

var builder = new SQLQueryBuilder();

var query = builder
    .Select("name, age")
    .From("users")
    .Where("age > 18")
    .OrderBy("name")
    .Build();

Console.WriteLine(query);

Console.WriteLine("Hello, World!");