using System;

namespace Zoo
{
    public class Animal : IAnimalInfo
    {
        protected double weight;
        protected int age;
        protected double costPerDay;

        public Animal(double weight, int age, double costPerDay)
        {
            this.weight = weight;
            this.age = age;
            this.costPerDay = costPerDay;
        }

        public virtual object this[string propertyName]
        {
            get
            {
                if (propertyName.ToLower() == "weight")
                    return weight;
                else if (propertyName.ToLower() == "age")
                    return age;
                else if (propertyName.ToLower() == "costperday")
                    return costPerDay;
                else
                    return null;
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Age: {age} years");
            Console.WriteLine($"Cost per day: {costPerDay} $");
        }

        public virtual object Clone()
        {
            return new Animal(weight, age, costPerDay);
        }

        public virtual int CompareTo(Animal other)
        {
            if (other == null) return 1;
            return costPerDay.CompareTo(other.costPerDay);
        }
    }
}

