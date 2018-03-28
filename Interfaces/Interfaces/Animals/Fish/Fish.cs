using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Zoo.Animals.Fish
{
    /// <summary>
    /// Base class for the fish in our zoo
    /// </summary>
    public abstract class Fish : Animal, ISwim
    {
        public override int Legs { get; protected set; } = 0;
        protected override string Phrase { get; set; } = "Bloop";

        public override string Move()
        {
            return Swim();
        }

        public string Swim()
        {
            return $"The {Name} swims around happily.";
        }
    }
}
