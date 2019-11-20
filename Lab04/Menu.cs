using Project.Animals;
using System;


namespace Project.Menu
{
    sealed class MainMenu
    {
        private const string ERROR = "Invalid Entry.";
        private static string userInput;
        private const int FIRST_OPTION = 1;
        private const int THIRD_OPTION = 1;
        private const int ARRAY_INDEX = 0;
        private const int QUIT = 3;
        private const float INVALID_WEIGHT = -999.9f;

        private string[] animalKinds;

        public MainMenu(string[] animalKinds)
        {
            this.animalKinds = animalKinds;

        }

        public string DisplayMainMenu()
        {
            Console.WriteLine("\n" + "================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            for (int i = ARRAY_INDEX; i < animalKinds.Length; i++)
            {
                Console.WriteLine((i + FIRST_OPTION).ToString() + ". " + animalKinds[i]);
            }
            Console.WriteLine((animalKinds.Length + THIRD_OPTION).ToString() + ". Quit");
            Console.Write("Selection:     ");
            userInput = Console.ReadLine();
            return userInput;
        }

        public string GetMainMenu()
        {
            int selectedItemNumber = 0;
            userInput = DisplayMainMenu();

            while (!int.TryParse(userInput, out selectedItemNumber)
                    || selectedItemNumber < ARRAY_INDEX
                    || selectedItemNumber > animalKinds.Length)
            {
                if (selectedItemNumber == QUIT)
                {
                    Console.WriteLine("\n" + "Thank you.  Your session is now over.");
                    userInput = Console.ReadLine();
                    return "Quit";
                }
                Console.WriteLine(ERROR);
                userInput = DisplayMainMenu();
                selectedItemNumber++;
            }
            return animalKinds[selectedItemNumber - FIRST_OPTION];
        }

        public string PromptForSpecies(Animal animal)
        {
            Console.WriteLine("\n" + "Species");
            Console.WriteLine("-------");
            for (int i = ARRAY_INDEX; i < animal.SpeciesOptions.Length; i++)
            {
                string speciesOption = animal.SpeciesOptions[i];
                Console.WriteLine((i + FIRST_OPTION).ToString() + ". {0}", speciesOption);
            }
            Console.Write("Selection:     ");
            userInput = Console.ReadLine();
            return userInput;
        }

        public string GetSpecies(Animal animal)
        {
            int selectedIndex = 0;
            userInput = PromptForSpecies(animal);

            while (!int.TryParse(userInput, out selectedIndex) || selectedIndex < ARRAY_INDEX
                    || selectedIndex > animal.SpeciesOptions.Length)
            {
                Console.WriteLine(ERROR);
                userInput = PromptForSpecies(animal);
            }
            return animal.SpeciesOptions[selectedIndex - FIRST_OPTION];
        }

        public float PromptForWeight()
        {
            int negativeWeight = 0;
            float selectedWeight;

            Console.Write("Weight in KG:  ");
            userInput = Console.ReadLine();

            if (!float.TryParse(userInput, out selectedWeight) || float.Parse(userInput) <= negativeWeight)
            {
                Console.WriteLine(ERROR + "\n");
                return INVALID_WEIGHT;
            }
            return selectedWeight;
        }

        public float GetWeight()
        {
            float input;
            do
            {
                input = PromptForWeight();
            } while (input == INVALID_WEIGHT);
            return input;
        }//end method

        //Display a meal recommendation, based on the user selected animal type, species and weight. 
        public void DisplayRecommendation(Animal animal)
        {
            Console.WriteLine("\n" + "Meal Recommendation");
            Console.WriteLine("--------------------");
            Console.WriteLine("Mammal Type:  {0}", animal.MammalType);
            Console.WriteLine("Species:      {0}", animal.Species);
            Console.WriteLine("Weight:       {0}" + " KG", animal.Weight.ToString("F"));
            Console.WriteLine("Serving:      {0} KG {1}.", animal.Serving.ToString("N3"), animal.Meal);
            Console.WriteLine("\n" + "Instructions: {0}", animal.Instructions);
            Console.WriteLine("              Feed at {0}.", animal.Time);
        }

    }
}
