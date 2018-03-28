using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Aquarium
    {
        private ISwim[] swimmers = new ISwim[0];

        /// <summary>
        /// Adds a new swimmer to the aquarium and returns the amount of
        /// swimmers that are now in the aquarium
        /// </summary>
        /// <param name="newSwimmer">The swimmer to add to the aquarium</param>
        /// <returns>The number of swimmers in the aquarium after adding the
        /// new swimmer</returns>
        public int AddSwimmer(ISwim newSwimmer)
        {
            ISwim[] newSwimmerArray = new ISwim[swimmers.Length + 1];
            swimmers.CopyTo(newSwimmerArray, 0);

            newSwimmerArray[newSwimmerArray.Length - 1] = newSwimmer;
            swimmers = newSwimmerArray;

            return swimmers.Length;
        }

        /// <summary>
        /// Creates an array of strings containing the swimming messages
        /// each swimmer in the aquarium is generating
        /// </summary>
        /// <returns>An array of swimmers' swimming strings in the aquarium</returns>
        public string[] CreateSwimmerStrings()
        {
            string[] swimmerStrings = new string[swimmers.Length];

            for (int swimmerIndex = 0; swimmerIndex < swimmers.Length; swimmerIndex++)
            {
                swimmerStrings[swimmerIndex] = swimmers[swimmerIndex].Swim();
            }

            return swimmerStrings;
        }
    }
}
