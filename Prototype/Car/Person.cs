namespace Prototype.Car;

public class Person : IClone<Person>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }


    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
    }
    public Person Clone()
    {
        return new Person()
        {
            Name = this.Name,
            Surname = this.Surname,
            Age = this.Age
        };
    }
}