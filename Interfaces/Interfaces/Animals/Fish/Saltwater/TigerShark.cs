using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals.Fish.Saltwater
{
    /// <summary>
    /// Class for the tiger sharks in our zoo
    /// </summary>
    public class TigerShark : Saltwater
    {
        public override string Name { get; protected set; } = "Tiger Shark";
        protected override string Diet { get; set; } = "Fish";
    }
}
