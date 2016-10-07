﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FilmsLibrary
{
   public class FilmsRecommendationSystem
    {
        public List<NewUser> accountsList = new List<NewUser>();
        public List<Film> filmsList = new List<Film>();
        public List<string> userCollection = new List<string>();
        public List<double> ratingList = new List<double>();
        public List<DateTime> filmsWasWatched = new List<DateTime>();

        public void addNewUser(string Nickname, string Email, string Name, string Surname)
        {
            accountsList.Add(new NewUser(Nickname, Email, Name, Surname));
            string serializedUsers = (JsonConvert.SerializeObject(accountsList));
        }
        public void addNewFilm(string Title, string Producer, string Genre)
        {
            filmsList.Add(new Film(Title, Producer, Genre));
            string serializedFilms = (JsonConvert.SerializeObject(filmsList));

            userCollection.Add(serializedFilms);
            string serializedFilmsList = (JsonConvert.SerializeObject(userCollection));
        }
        public void filmsRatings(double rating)
        {

           ratingList.Add(rating);
        }

        public double filmAverageRating()
        {
          
            
            return 0;

        }



    }
}
