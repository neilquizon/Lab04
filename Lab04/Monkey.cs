﻿using System;


namespace Project.Animals
{
    sealed class Monkey : Mammal
    {
        private const string MAMMAL_TYPE = "Monkey";
        private const float NO_WEIGHT = 0.0f;
        private const float COLOBUS_WEIGHT = 0.008f;
        private const float HOWLER_WEIGHT = 0.007f;
        private const float SQUIRREL_WEIGHT = 0.006f;

        public Monkey()
            : base(MAMMAL_TYPE)
        {

        }

        private string[] speciesOptions = new string[]
        {
            "Squirrel",
            "Howler",
            "Colobus"
        };

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
                    case "Squirrel":
                        return this.Weight * SQUIRREL_WEIGHT;

                    case "Howler":
                        return this.Weight * HOWLER_WEIGHT;

                    case "Colobus":
                        return this.Weight * COLOBUS_WEIGHT;

                    default:
                        return NO_WEIGHT;
                }
            }
        }

        public override string Meal
        {
            get
            {

                return "fresh fruit, vegetables, nuts, insects, berries";

            }
        }

        public override string Time
        {
            get
            {
                return "9AM, 12PM and 5PM";
            }
        }
    }
}
