using System;
using System.Collections.Generic;

namespace Practice_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare userContinue for our while loop
            string userContinue = "y";

            //while loop to ask user to continue
            while (userContinue != "n")
            {
                //create list of movies
                List<Movies> listOfMovies = new List<Movies>
            {
                new Movies("Die Hard", "Action"),
                new Movies("Bad Boys", "Action"),
                new Movies("Men In Black", "Scifi"),
                new Movies("Star Wars", "Scifi"),
                new Movies("Toy Story", "Family"),
                new Movies("The Mighty Ducks", "Family"),
                new Movies("Office Space", "Comedy"),
                new Movies("Happy Gilmore", "Comedy"),
                new Movies("The Ring", "Horror"),
                new Movies("The sHining", "Horror"),
            };

                //display welcome message and ask for user input
                Console.Write("Welcome to the Awesome Movie Library!\nWe have over ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("TEN");
                Console.ResetColor();
                Console.Write(" movies in stock!!\n");

                Console.WriteLine("Here are the genres of movies we have:\n");

                Movies.PrintMovieTypes(listOfMovies);

                Console.WriteLine("Which genre are you feeling tonight?\n");

                string userInput = Console.ReadLine().ToLower();

                //return the movies in selected genre
                Console.WriteLine($"These are the {userInput} movies");
                Console.WriteLine(Movies.PrintMoviesByType(listOfMovies, userInput));

                //ask user if they want to try a different genre
                Console.WriteLine("Would you like to search a different genre? y/n");
                userContinue = Console.ReadLine();
            }
        }
    }
}
