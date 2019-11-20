using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Animals
{
    sealed class Bear : Mammal
    {
        private const float NO_WEIGHT = 0.0f;
        private const float POLAR_WEIGHT = 0.016f;
        private const float BLACK_WEIGHT = 0.014f;
        private const string MAMMAL_TYPE = "Bear";

        public Bear()
            : base(MAMMAL_TYPE)
        {

        }

        private string[] speciesOptions = new string[] { "Black", "Polar" };

        public override string[] SpeciesOptions
        {
            get { return this.speciesOptions; }
        }

        public override float Serving
        {
            get
            {
                switch (Species)
                {
                    case "Black":
                        return this.Weight * BLACK_WEIGHT;

                    case "Polar":
                        return this.Weight * POLAR_WEIGHT;

                    default:
                        return NO_WEIGHT;
                }
            }
        }

        public override string Meal
        {
            get
            {
                switch (Species)
                {
                    case "Black":
                        return "berries, green vegetation, flowers, fruits, fish";

                    case "Polar":
                        return "berries, fish";

                    default:
                        return "";
                }
            }
        }

        public override string Time
        {
            get
            {
                return "9AM and 3PM";
            }
        }



    }
}
