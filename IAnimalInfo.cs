using System;

namespace Zoo
{
    public interface IAnimalInfo : ICloneable, IComparable<Animal>
    {
        void ShowInfo();
    }
}
