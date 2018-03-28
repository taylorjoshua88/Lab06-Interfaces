using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Grounded
{
    /// <summary>
    /// Base class for the grounded birds in our zoo
    /// </summary>
    public abstract class Grounded : Bird
    {
        public override string Move()
        {
            return $"The {Name} sprints about.";
        }
    }
}
