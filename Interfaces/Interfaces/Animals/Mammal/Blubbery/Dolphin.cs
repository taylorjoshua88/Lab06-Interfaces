using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Zoo.Animals.Mammal.Blubbery
{
    public class Dolphin : Blubbery, ISwim, IPlay
    {
        public override string Name { get; protected set; } = "Dolphin";
        protected override string Diet { get; set; } = "Fish";
        protected override string Phrase { get; set; } = "Squawk";

        public override string Move()
        {
            return Swim();
        }

        public string Play()
        {
            return $"The {Name} is having a good time playing.";
        }

        public string Swim()
        {
            return $"The {Name} swims around joyfully.";
        }
    }
}
