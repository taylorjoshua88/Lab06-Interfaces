using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Feline
{
    /// <summary>
    /// Class for the lions in our zoo
    /// </summary>
    public class Lion : Feline
    {
        public override string Name { get; protected set; } = "Lion";
        protected override string Diet { get; set; } = "Wildebeest";
        protected override string Phrase { get; set; } = "Roar";
        public override int FurLength { get; set; } = 5;

        public override string Move()
        {
            return $"The {Name} majestically pounces to and fro with its {Legs} legs.";
        }
    }
}
