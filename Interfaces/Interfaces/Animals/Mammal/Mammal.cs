using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal
{
    /// <summary>
    /// Base class for the mammals in our zoo
    /// </summary>
    public abstract class Mammal : Animal
    {
        public abstract int FurLength { get; set; }
        public override int Legs { get; protected set; } = 4;

        public override string Move()
        {
            return $"The {Name} tromps around trompingly on its {Legs} legs.";
        }
    }
}
