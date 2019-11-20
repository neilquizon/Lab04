using System;

namespace Project.Animals
{
    public abstract class Mammal : Animal
    {
        public Mammal(string mammalType)
            : base(mammalType)
        {

        }
        public override string Instructions
        {
            get
            {
                return "Keep area secure at all times.";
            }
        }

    }
}
