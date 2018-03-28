using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Animals
{
    /// <summary>
    /// Base class for all the animals in our zoo
    /// </summary>
    public abstract class Animal
    {
        /// <summary>
        /// The name of this animal's species
        /// </summary>
        public abstract string Name { get; protected set; }

        /// <summary>
        /// What this species likes to eat
        /// </summary>
        protected abstract string Diet { get; set; }

        /// <summary>
        /// What sound this species makes
        /// </summary>
        protected abstract string Phrase { get; set; }

        /// <summary>
        /// How many legs does a healthy specimen of this species have
        /// </summary>
        public virtual int Legs { get; protected set; } = 4;

        /// <summary>
        /// Is this animal alive?
        /// </summary>
        public virtual bool IsAlive { get; set; } = true;

        /// <summary>
        /// Make this animal eat
        /// </summary>
        /// <returns>A string representing the animal eating</returns>
        public string Eat()
        {
            return $"The {Name} enjoyed eating {Diet}!";
        }

        /// <summary>
        /// Make this animal speak
        /// </summary>
        /// <returns>A string representing this animal making a noise</returns>
        public string Speak()
        {
            return $"The {Name} says {Phrase}";
        }

        /// <summary>
        /// Make this animal move by its normal means
        /// </summary>
        /// <returns>A string representing this animal moving about</returns>
        public abstract string Move();

        /// <summary>
        /// Make this animal shed its feathers, skin, etc.
        /// </summary>
        /// <returns>A string representing this animal molting</returns>
        public virtual string Molt()
        {
            return $"The {Name} cannot molt!";
        }

        /// <summary>
        /// Check to see if this animal is still alive
        /// </summary>
        /// <returns>True if the animal has a pulse. False if it is dead.</returns>
        public bool CheckPulse()
        {
            return IsAlive;
        }
    }
}
