using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Toy
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                // Argument validation
                if (value is null)
                {
                    throw new ArgumentNullException("Toys need to have names", nameof(value));
                }
                if (value.Length < 1)
                {
                    throw new ArgumentException("Toys cannot have blank names", nameof(value));
                }

                _name = value;
            }
        }

        /// <summary>
        /// Constructor which sets the toy's name
        /// </summary>
        /// <param name="name">The name of the new toy</param>
        public Toy(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Entertain an object that implements the IPlay interface. Returns a string mentioning
        /// that the player has been entertained with their Play() response after a line break.
        /// </summary>
        /// <param name="player">The player who is being entertained by this toy</param>
        /// <returns>A string mentioning that a player has been entertained along with their
        /// Play() response after a line break</returns>
        public string Entertain(IPlay player)
        {
            return $"The {Name} has entertained a playful animal:\n{player.Play()}";
        }
    }
}
