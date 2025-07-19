namespace Builder.User;

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Email: {Email}, Phone: {Phone}.";
    }
}