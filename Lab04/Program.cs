using System;


namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] animalKinds = new string[] { "Monkey", "Bear" };
            MainMenu menu = new MainMenu(animalKinds);
            string selectedOption;

            while ((selectedOption = menu.GetMainMenu()) != "Quit")
            {
                Animal animal = GetMainOption(selectedOption);
                animal.Species = menu.GetSpecies(animal);
                animal.Weight = menu.GetWeight();
                menu.DisplayRecommendation(animal);
            }            
        }


    }
}
