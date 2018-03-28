using System;

namespace Interfaces
{
    class Program
    {
        /// <summary>
        /// Entry point for our program
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to our zoo!");

            PresentSwimmers();

            Console.WriteLine();
            Console.WriteLine("That's it for our swimmers! Please press a key for our next");
            Console.WriteLine("set of animals...");
            Console.ReadKey();
            Console.Clear();

            PresentPlayers();

            Console.WriteLine("\nPlease press a key for some closing words...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("You have now been on two tours of our zoo.");
            Console.WriteLine("You may have noticed that we share many traits with our animal friends.");
            Console.WriteLine("\nAs always, I hope this experience has helped you gain an appreciation");
            Console.WriteLine("for the wonderful creatures we share our planet with.");
            Console.WriteLine("\nPlease press a key to leave the zoo...");

            Console.ReadKey();
        }

        /// <summary>
        /// Outputs a series of strings to the console emulating a tour guide walking an audience
        /// through the various swimming animals at the zoo.
        /// </summary>
        static void PresentSwimmers()
        {
            Console.WriteLine("\nWe would like to show off all of the great swimmers");
            Console.WriteLine("of our zoo today!");

            Console.WriteLine("\nFirst, we have an aquarium full of fish that you might");
            Console.WriteLine("remember from our last tour.");

            Aquarium aquarium = new Aquarium();

            aquarium.AddSwimmer(new Zoo.Animals.Fish.Freshwater.Bass());
            aquarium.AddSwimmer(new Zoo.Animals.Fish.Freshwater.Bluegill());
            aquarium.AddSwimmer(new Zoo.Animals.Fish.Saltwater.Sardine());
            aquarium.AddSwimmer(new Zoo.Animals.Fish.Saltwater.TigerShark());

            Console.WriteLine("\nLet's watch them act in their natural environment!");
            Console.WriteLine("Please press a key to continue...");
            Console.ReadKey();
            Console.Clear();

            foreach (string swimmerString in aquarium.CreateSwimmerStrings())
            {
                Console.WriteLine(swimmerString);
                Console.WriteLine();
            }

            Console.WriteLine("\nNow we have a surprise for you after you press a key...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("*drumroll*");
            Console.WriteLine("DOLPHINS!!!!!");
            Console.WriteLine();

            ISwim dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();
            Console.WriteLine(dolphin.Swim());
        }

        /// <summary>
        /// Outputs a series of strings to the console which emulate a tour guide walking an
        /// audience through a couple of the playful animals at the zoo
        /// </summary>
        static void PresentPlayers()
        {
            Console.WriteLine("These animals enjoy playing around just like we do from time to time.");

            Zoo.Animals.Mammal.Blubbery.Dolphin dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();
            Toy ball = new Toy("Ball");

            Console.WriteLine("\nThis first animal we have actually just watched swimming around");
            Console.WriteLine($"Let's throw our {dolphin.Name} a {ball.Name} to play with!");

            Console.WriteLine();
            Console.WriteLine(ball.Entertain(dolphin));
            Console.WriteLine();

            Zoo.Animals.Mammal.Feline.Cat cat = new Zoo.Animals.Mammal.Feline.Cat();
            Toy yarn = new Toy("Yarn");

            Console.WriteLine("This next animal can be commonly seen in our houses.");
            Console.WriteLine($"Let's throw some {yarn.Name} over to this {cat.Name}.");
            Console.WriteLine();
            Console.WriteLine(yarn.Entertain(cat));
        }
    }
}
