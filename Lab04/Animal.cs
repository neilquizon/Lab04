using System;


namespace Project.Animals
{
    public abstract class Animal
    {
        // Type of Mammal: Bear or Monkey
        public string MammalType { get; set; }

        // Type of Species: (Bear: Polar, Black), (Monkey: Squirrel, Howler, Colobus)
        public virtual string Species { get; set; }

        // User inputs weight
        public virtual float Weight { get; set; }

        // user's selected weight multiplier
        public abstract float Serving { get; }

        // Time based on selected Mammal type
        public abstract string Time { get; }

        // Meal based on selected Mammal type
        public abstract string Meal { get; }

        // Instructions for Animals
        public abstract string Instructions { get; }

        // Species options based on selected Mammal type
        public abstract string[] SpeciesOptions { get; }

    }
}
