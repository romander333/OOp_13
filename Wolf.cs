using System;
using Zoo;

public class Wolf : Animal
{
    protected string breed;
    protected string location;

    public Wolf(double weight, int age, double costPerDay, string breed, string location)
        : base(weight, age, costPerDay)
    {
        this.breed = breed;
        this.location = location;
    }

    public override object this[string propertyName]
    {
        get
        {
            var prop = propertyName.ToLower();

            if (prop == "breed")
                return breed;
            else if (prop == "location")
                return location;
            else
                return base[prop]; // передає запит до Animal
        }
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Breed: {breed}");
        Console.WriteLine($"Location: {location}");
    }

    public override object Clone()
    {
        return new Wolf((double)this["weight"], (int)this["age"], (double)this["costperday"], breed, location);
    }

    public override int CompareTo(Animal other)
    {
        if (other == null) return 1;
        return base.CompareTo(other);
    }
}