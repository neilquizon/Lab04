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
        public static Animal GetMainOption(string animal)
        {
            switch (animal)
            {
                case "Monkey":
                    return new Monkey();

                case "Bear":
                    return new Bear();

                case "Quit":
                    return null;

                default:
                    throw new NotImplementedException(); //We only support monkey and bear
            }
        }


    }
}
