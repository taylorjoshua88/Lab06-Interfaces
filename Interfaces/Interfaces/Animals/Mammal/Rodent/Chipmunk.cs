using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Mammal.Rodent
{
    /// <summary>
    /// Class for the chipmunks in our zoo
    /// </summary>
    public class Chipmunk : Rodent
    {
        public override string Name { get; protected set; } = "Chipmunk";
        protected override string Diet { get; set; } = "Acorns";
        public override int FurLength { get; set; } = 3;
    }
}
