﻿
namespace IntroChangeVariableValues
{
    internal class Program
    {
        private string myFavoriteCity;
        private int myFavoriteNumber;
        private bool displayNumber;
        private string characterName;
        private DateTime currentTime;


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            string character1 = "mario";
            string character2 = "luigi";

            characterName = character1;
            currentTime= DateTime.Now;
            myFavoriteCity = "Amsterdam"; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = 64; //geef hier myFavoriteNumber een waarde 
            displayNumber = true; //zet displayNumber op true
            Display();

            //nu gaan we de waarden instellen voor luigi, gebruik andere waardes

            characterName = "Luigi";
            currentTime = (DateTime.Now.TimeOfDay);//zoek op hoe je de huidige tijd kan krijgen (DateTime.???)
            myFavoriteCity = "Den haag"; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = 43; //geef hier myFavoriteNumber een waarde 
            displayNumber = false; //zet displayNumber op false
            Display();
        }

        private void Display()
        {
            Console.WriteLine("hi i'm "+characterName);
            Console.WriteLine("it is now " + currentTime);

            Console.WriteLine("my favorite city is:");
            Console.WriteLine(myFavoriteCity);
            if (displayNumber)
            {
                Console.WriteLine("my favorite number is:");
                Console.WriteLine(displayNumber);
            }
        }
    }
}
