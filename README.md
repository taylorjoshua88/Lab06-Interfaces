# Interfaces

**Author**: Joshua Taylor
**Version**: 1.0.0

## Overview

Interfaces builds on [Lab05](https://github.com/taylorjoshua88/Lab05-OOP-Principles)'s zoo animals class hierarchy by introducing
interfaces. Interfaces provide a contract which classes can implement in
order to reference them by their shared behavior rather than their place
in an inheritance hierarchy. Classes at any level can choose to implement
interfaces so long as they provide implementations for all of the methods
and properties that the interface calls for.

## Getting Started

Interfaces targets the .NET Core 2.0 platform. The .NET Core 2.0 SDK can
be downloaded from the following URL for Windows, Linux, and macOS:

https://www.microsoft.com/net/download/

The dotnet CLI utility would then be used to build and run the application:

    cd Interfaces
    dotnet build
    dotnet run

Additionally, users can build, run, and perform unit testing using Visual
Studio 2017 or greater by opening the solution file at the root of this
repository.

## Example

#### Interface Demonstration Screenshot ####
![Interface Demo Screenshot](/assets/screenshot.jpg)

## Architecture

Interfaces contains the same classes and hierarchy as can be found on
[Lab05](https://github.com/taylorjoshua88/Lab05-OOP-Principles). In addition,
a new abstract class has been added under Mammal, Blubbery, which represents
mammals with blubber such as whales and dolphins. A concrete class for
dolphins has been added, Dolphin, which implements both of our new
interfaces.

### ISwim

ISwim is an interface which can be implemented by any class representing an
animal with the ability to swim. This interface only requires one method,
Swim(), which returns a string describing that animal swimming. The Fish
abstract class implements this interface, meaning that all classes beneath
that class can be referred to using the ISwim interface. In addition, the
new Dolphin concrete class implements this interface.

Classes that implement ISwim can be added to an aquarium and are expected
to have the Swim() method implemented.

### IPlay

IPlay is to be implemented by any animal that can act playfully. It requires
that classes implement a single method called Play() which returns a string
representing the act of that animal playing.

Classes that implement IPlay can be entertained by Toy objects and are
expected to implement the Play() method.

### Class Hierarchy

The following is a graphical representation of the interfaces and
class hierarchy for all derived animal classes and their bases, ultimately
leading to the master base class, Animal. Each class in the following diagram
include the access modifiers (encapsulation), abstractions (abstraction /
polymorphism), and inheritance represented by arrows (inheritance).

![Class and Interface Diagram](/assets/interfaceHierarchy.jpg)

### Data Model

All data is stored in memory on the heap by instantiating classes using the
*new* keyword and by storing references through interfaces.
No data persistence is supported by this application.

### Command Line Interface (CLI)

Interfaces's interface is a simple console-based command line interface.
Text is written to the console emulating a tour guide giving a second tour
of the zoo, introducing the animals which can swim and giving toys to
cats and dolphins to play with. User input is provided via the keyboard
through System.Console.ReadKey() and serves only to provide pauses in
operation.

## Change Log

* 3.27.2018 [Joshua Taylor](mailto:taylor.joshua88@gmail.com) - Initial
release. All tests are passing.