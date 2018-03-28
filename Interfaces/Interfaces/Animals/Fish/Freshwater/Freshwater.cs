using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Freshwater
{
    /// <summary>
    /// Base class for the freshwater fish in our zoo
    /// </summary>
    public abstract class Freshwater : Fish
    {
        protected override string Diet { get; set; } = "Worms";
    }
}
