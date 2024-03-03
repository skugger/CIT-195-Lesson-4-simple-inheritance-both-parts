namusing System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = string.Empty;

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    // derived class of Animal 

    class Pet : Animal
    {
        public string family;
        public string genus;
        public string species;
        public string commonName;

        public Pet()
            : base()
        {
            family = string.Empty;
            genus = string.Empty;
            species = string.Empty;
            commonName = string.Empty;
        }
        public Pet(string name, string family, string genus, string species, string commonName)
            : base(name)
        {
            this.family = family;
            this.genus = genus;
            this.species = species;
            this.commonName = commonName;
        }
        public void getName() { Console.WriteLine($"Name: {name}"); }
        public void getFamily() { Console.WriteLine($"Family: {family}"); }
        public void getGenus() { Console.WriteLine($"Genus: {genus}"); }
        public void getSpecies() { Console.WriteLine($"Species: {species}"); }
        public void getcommonName() { Console.WriteLine($"Common name: {commonName}"); }
    }
    class Source : Animal
    {
        public string sourceType;
        public string sourceName;
        public int sourceYear;
        public string sourceAuthor;

        public Source()
            : base()
        {
            sourceType = string.Empty;
            sourceName = string.Empty;
            sourceYear = 0;
            sourceAuthor = string.Empty;
        }
        public Source(string name, string sourceType, string sourceName, int sourceYear, string sourceAuthor)
            : base(name)
        {
            this.sourceType = sourceType;
            this.sourceName = sourceName;
            this.sourceYear = sourceYear;
            this.sourceAuthor = sourceAuthor;
        }
        public void getName() { Console.WriteLine($"Name: {name}"); }
        public void getsourceType() { Console.WriteLine($"Source Type: {sourceType}"); }
        public void getsourceName() { Console.WriteLine($"Source Name: {sourceName} ({sourceYear})"); }
        public void getsourceAuthor() { Console.WriteLine($"Author: {sourceAuthor}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // object of base class
            Animal myPet = new Animal();
            myPet.name = "Sparky";
            myPet.display();

            // derived class object using default constructor
            Pet fish = new Pet();
            fish.genus = "Pterophyllum";
            fish.family = "Cichlidae";
            fish.species = "scalare";
            fish.commonName = "Angelfish";
            fish.name = "Wanda";

            Console.WriteLine();
            fish.getFamily();
            fish.getGenus();
            fish.getSpecies();
            fish.getcommonName();
            fish.getName();

            Console.WriteLine();
            Source fishMovie = new Source();
            fishMovie.sourceName = "A Fish Called Wanda";
            fishMovie.sourceType = "movie";
            fishMovie.sourceAuthor = "Monty Python";
            fishMovie.sourceYear = 1988;
            fishMovie.name = "Wanda";

            fishMovie.getName();
            fishMovie.getsourceName();
            fishMovie.getsourceType();
            fishMovie.getsourceAuthor();

            //derived class object using parameterized constructor

            Pet parrott = new Pet("Mr. Polly Parrott", "Psittacidae", "Norwegius", "azureus", "Norwegian Blue");
            Console.WriteLine();
            parrott.getFamily();
            parrott.getGenus();
            parrott.getSpecies();
            parrott.getcommonName();
            parrott.getName();

            Source parrotSketch = new Source("Mr. Polly Parrot", "sketch", "the 'Dead Parrot' sketch", 1969, "Monty Python");
            Console.WriteLine();
            parrotSketch.getName();
            parrotSketch.getsourceName();
            parrotSketch.getsourceType();
            parrotSketch.getsourceAuthor();

        }

    }
}
