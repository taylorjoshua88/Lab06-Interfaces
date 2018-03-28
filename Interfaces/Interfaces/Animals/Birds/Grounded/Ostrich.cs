using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Birds.Grounded
{
    /// <summary>
    /// Class for the ostriches in our zoo
    /// </summary>
    public class Ostrich : Grounded
    {
        public override string Name { get; protected set; } = "Ostrich";
        protected override string Phrase { get; set; } = "Boom";
    }
}
