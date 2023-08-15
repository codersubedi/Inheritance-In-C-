using System;

// Base class: Animal
class Animal
{
    public string Name { get; set; }

    // Constructor
    public Animal(string name)
    {
        Name = name;
    }

    // Method to make the animal sound
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a generic sound.");
    }
}

// Subclass 1: Cow
class Cow : Animal
{
    public Cow(string name) : base(name)
    {
    }

    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("The cow says 'Moo!'");
    }
}

// Subclass 2: Goat
class Goat : Animal
{
    public Goat(string name) : base(name)
    {
    }

    // Override the MakeSound method
    public override void MakeSound()
    {
        Console.WriteLine("The goat says 'Baa!'");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Cow and Goat
        Cow cow = new Cow("Bessie");
        Goat goat = new Goat("Billy");

        // Make the animals sound
        cow.MakeSound();
        goat.MakeSound();
    }
}
