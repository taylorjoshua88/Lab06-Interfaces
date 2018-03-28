using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Grounded
{
    /// <summary>
    /// Class for the dodo corpses in our zoo
    /// </summary>
    public class Dodo : Grounded
    {
        public override bool IsAlive { get; set; } = false;
        public override string Name { get; protected set; } = "Dodo";
        protected override string Phrase { get; set; } = "Nothing...anymore";

        public override string Move()
        {
            return $"The {Name} hasn't moved in over 100 years.";
        }

        public override string Molt()
        {
            return $"The {Name}'s feathers decayed long ago and can no longer molt.";
        }
    }
}
