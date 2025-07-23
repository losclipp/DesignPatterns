namespace Builder.Person;

public class Person
{
    public string Name { get; init; }
    public string Surname { get; init; }
    public int Age { get; init; }
    public string PassportNumber { get; init; }

    public override string ToString()
    {
        return $"{Name}, {Surname}, {Age}, {PassportNumber}";
    }
}