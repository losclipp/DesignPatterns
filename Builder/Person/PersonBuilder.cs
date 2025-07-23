using System.Text.RegularExpressions;

namespace Builder.Person;

public class PersonBuilder
{
    private string _name ="";
    private string _Surname ="";
    private int _age = 0;
    private string _passportNumber = "";

    public PersonBuilder AddName(string name)
    {
        ValidateName(name);
        _name = name;
        return this;
    }

    public PersonBuilder AddSurname(string Surname)
    {
        ValidateSurname(Surname);
        _Surname = Surname;
        return this;
    }
    
    public PersonBuilder AddAge(int age)
    {
        ValidateAge(age);
        _age = age;
        return this;
    }

    public PersonBuilder AddPassportNumber(string passportNumber)
    {
        ValidatePassportNumber(passportNumber);
        _passportNumber = passportNumber;
        return this;
    }

    public Person Build()
    {
        ValidateName(_name);
        ValidateSurname(_Surname);
        ValidateAge(_age);
        ValidatePassportNumber(_passportNumber);
        
        return new Person()
        {
            Name = _name,
            Surname = _Surname,
            Age = _age,
            PassportNumber = _passportNumber
        };
    }

    private void ValidateName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
        }

        if (!Regex.IsMatch(name, @"^\w+"))
        {
            throw new ArgumentException("Invalid name.", nameof(name));
        }
    }

    private void ValidateSurname(string Surname)
    {
        if (string.IsNullOrWhiteSpace(Surname))
        {
            throw new ArgumentException("Surname cannot be null or whitespace.", nameof(Surname));
        }

        if (!Regex.IsMatch(Surname, @"^\w+"))
        {
            throw new ArgumentException("Invalid Surname.", nameof(Surname));
        }
    }

    private void ValidateAge(int age)
    {
        if (age < 1)
        {
            throw new ArgumentException("Age cannot be less than 1.", nameof(age));
        }
    }

    private void ValidatePassportNumber(string passportNumber)
    {
        if (string.IsNullOrWhiteSpace(passportNumber))
        {
            throw new ArgumentException("Passport number cannot be null or whitespace.", nameof(passportNumber));
        }

        if (!Regex.IsMatch(passportNumber, @"^[a-zA-Z0-9]+$"))
        {
            throw new ArgumentException("Invalid passport number.", nameof(passportNumber));
        }
    }
 }