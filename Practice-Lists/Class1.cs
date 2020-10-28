using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Lists
{
    //created class Movies
    class Movies
    {
        //fields
        private string name;
        private string genre;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        //Constructors
        public Movies()
        {

        }

        public Movies(string _name, string _genre)
        {
            name = _name;
            genre = _genre;

        }

        //create list of movies
        private static List<string> GetListOfMovieTypes(List<Movies> movieList)
        {
            List<string> movieGenre = new List<string>();
            foreach (Movies film in movieList)
            {
                if (!movieGenre.Contains(film.genre))
                {
                    movieGenre.Add(film.genre);
                }
            }
            return movieGenre;
        }

        //print movie genre
        public static void PrintMovieTypes(List<Movies> movieList)
        {
            List<string> movieTypes = GetListOfMovieTypes(movieList);
            foreach (string type in movieTypes)
            {
                Console.WriteLine($"{type}");
            }
        }

        //method to print movies by genre
        public static string PrintMoviesByType(List<Movies> movieList, string typeSelected)
        {
            //loop through movieList and create film variable
            foreach (Movies film in movieList)
            {

                if (typeSelected == "action")
                {
                    return "Die Hard\nBad Boys";
                    //return film.name;
                }

                if (typeSelected == "comedy")
                {
                    return "Office Space\nHappy Gilmore";
                    //return film.name;
                }

                if (typeSelected == "scifi")
                {
                    return "Men in Black\nStar Wars";
                    //return film.name;
                }

                if (typeSelected == "horror")
                {
                    return "The Ring\nThe sHining";
                    //return film.name;
                }

                if (typeSelected == "family")
                {
                    return "Toy Story\nThe Mighty Ducks";
                    //return film.name;
                }
                //continue;
                //tried to loop though foreach
            }
            return "";
        }
    }
}

