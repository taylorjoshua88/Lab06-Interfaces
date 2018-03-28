using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Rodent
{
    /// <summary>
    /// Base class for the rodents in our zoo
    /// </summary>
    public abstract class Rodent : Mammal
    {
        protected override string Phrase { get; set; } = "Squeak";

        public override string Move()
        {
            return $"The {Name} scurries around meekly.";
        }
    }
}
