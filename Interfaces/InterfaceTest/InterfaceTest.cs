using System;
using Xunit;
using Interfaces;

namespace InterfaceTest
{
    public class InterfaceTest
    {
        [Fact]
        public void CatImplementsIPlay()
        {
            // Arrange
            Zoo.Animals.Mammal.Feline.Cat cat = new Zoo.Animals.Mammal.Feline.Cat();

            // Assert
            Assert.IsAssignableFrom<IPlay>(cat);
        }

        [Fact]
        public void DolphinImplementsIPlay()
        {
            // Arrange
            Zoo.Animals.Mammal.Blubbery.Dolphin dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();

            // Assert
            Assert.IsAssignableFrom<IPlay>(dolphin);
        }

        [Fact]
        public void DolphinImplementsISwim()
        {
            // Arrange
            Zoo.Animals.Mammal.Blubbery.Dolphin dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();

            // Assert
            Assert.IsAssignableFrom<ISwim>(dolphin);
        }

        [Fact]
        public void BluegillImplementsISwim()
        {
            // Arrange
            Zoo.Animals.Fish.Freshwater.Bluegill bluegill = new Zoo.Animals.Fish.Freshwater.Bluegill();

            // Assert
            Assert.IsAssignableFrom<ISwim>(bluegill);
        }

        [Fact]
        public void BassImplementsISwim()
        {
            // Arrange
            Zoo.Animals.Fish.Freshwater.Bass bass = new Zoo.Animals.Fish.Freshwater.Bass();

            // Assert
            Assert.IsAssignableFrom<ISwim>(bass);
        }

        [Fact]
        public void SardineImplementsISwim()
        {
            // Arrange
            Zoo.Animals.Fish.Saltwater.Sardine sardine = new Zoo.Animals.Fish.Saltwater.Sardine();

            // Assert
            Assert.IsAssignableFrom<ISwim>(sardine);
        }

        [Fact]
        public void TigerSharkImplementsISwim()
        {
            // Arrange
            Zoo.Animals.Fish.Saltwater.TigerShark tigerShark = new Zoo.Animals.Fish.Saltwater.TigerShark();

            // Assert
            Assert.IsAssignableFrom<ISwim>(tigerShark);
        }

        [Fact]
        public void SardineCanEnterAquarium()
        {
            // Arrange
            Zoo.Animals.Fish.Saltwater.Sardine sardine = new Zoo.Animals.Fish.Saltwater.Sardine();
            Aquarium aquarium = new Aquarium();

            // Act
            int swimmerCount = aquarium.AddSwimmer(sardine);

            // Assert
            Assert.True(swimmerCount > 0);
        }

        [Fact]
        public void AquariumCanCreateSwimStrings()
        {
            // Arrange
            Zoo.Animals.Fish.Freshwater.Bass bass = new Zoo.Animals.Fish.Freshwater.Bass();
            Zoo.Animals.Fish.Saltwater.TigerShark tigerShark = new Zoo.Animals.Fish.Saltwater.TigerShark();
            Zoo.Animals.Mammal.Blubbery.Dolphin dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();
            Aquarium aquarium = new Aquarium();

            // Act
            aquarium.AddSwimmer(bass);
            aquarium.AddSwimmer(tigerShark);
            aquarium.AddSwimmer(dolphin);

            // Assert
            Assert.Equal(3, aquarium.CreateSwimmerStrings().Length);
        }

        [Fact]
        public void ToyCanEntertain()
        {
            // Arrange
            Zoo.Animals.Mammal.Blubbery.Dolphin dolphin = new Zoo.Animals.Mammal.Blubbery.Dolphin();
            Toy ball = new Toy("Ball");

            // Act
            string entertainString = ball.Entertain(dolphin);
            // Assert
            Assert.Contains("Ball", entertainString);
        }
    }
}
