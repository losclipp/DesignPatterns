namespace Builder.User;

public class UserBuilder
{
    private readonly User _user = new User();

    public UserBuilder AddName(string name)
    {
        _user.Name = name;
        return this;
    }
    
    public UserBuilder AddSurname(string surname)
    {
        _user.Surname = surname;
        return this;
    }
    
    public UserBuilder AddAge(int age)
    {
        _user.Age = age;
        return this;
    }
    
    public UserBuilder AddEmail(string email)
    {
        _user.Email = email;
        return this;
    }
    
    public UserBuilder AddPhone(string phone)
    {
        _user.Phone = phone;
        return this;
    }
    public User Build()
    {
        var validator = new UserValidator();
        var result = validator.Validate(_user);
        if (!result.IsValid)
        {
            result.Errors.ForEach(e => Console.WriteLine(e));
            return null;
        }
        
        return _user;
    }
}