using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Flying.Raptor
{
    /// <summary>
    /// Base class for the raptors in our zoo
    /// </summary>
    public abstract class Raptor : Flying
    {
        protected override string Diet { get; set; } = "Small Animals";
        protected override string Phrase { get; set; } = "Screech";

        public override string Hunt()
        {
            return $"The {Name} swoops down and grabs some {Diet}.";
        }
    }
}
