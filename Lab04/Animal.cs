using System;


namespace Project.Animals
{
    public abstract class Animal
    {
        // Type of Mammal: Bear or Monkey
        public string MammalType { get; set; }

        // Type of Species: (Bear: Polar, Black), (Monkey: Squirrel, Howler, Colobus)
        public virtual string Species { get; set; }

        //User inputs weight
        public virtual float Weight { get; set; }

    }
}
