using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace Zoo.Animals.Mammal.Feline
{
    /// <summary>
    /// Class for the cats in our zoo
    /// </summary>
    public class Cat : Feline, IPlay
    {
        public override string Name { get; protected set; } = "Cat";
        protected override string Diet { get; set; } = "Fancy Feast";
        public override int FurLength { get; set; } = 3;

        public string Play()
        {
            return $"The {Name} is having a good time playing around.";
        }
    }
}
