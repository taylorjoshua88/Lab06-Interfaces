using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Saltwater
{
    /// <summary>
    /// Base class for the saltwater fish in our zoo
    /// </summary>
    public abstract class Saltwater : Fish
    {
        protected override string Diet { get; set; } = "Plankton";
    }
}
