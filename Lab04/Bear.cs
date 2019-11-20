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



    }
}
