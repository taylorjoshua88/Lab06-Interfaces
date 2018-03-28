using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds
{
    /// <summary>
    /// Base class for the birds in our zoo
    /// </summary>
    public abstract class Bird : Animal
    {
        public override int Legs { get; protected set; } = 2;
        protected override string Diet { get; set; } = "Worms";
        public int Wings { get; set; } = 2;
        protected override string Phrase { get; set; } = "Chirp";

        public override string Molt()
        {
            return $"The {Name} has shed its feathers.";
        }

        public virtual string Hunt()
        {
            return $"The {Name} has sought out {Diet}";
        }
    }
}
