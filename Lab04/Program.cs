using System;
using Project;
using Project.Menu;
using Project.Animals;


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
