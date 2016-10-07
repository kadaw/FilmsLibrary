using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace FilmsLibrary
{
    [TestClass]
    public class UnitTest1
    {
      /*  [TestMethod]
        public void filmAverageRating_ReturnEqaul()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();

            List<double> ratingList = new List<double> { 2, 5, 5, 8 };
            double rightRating = 5;
        
            double averageRating = filmsRecomend.filmAverageRating();

            Assert.AreEqual(rightRating, averageRating);

        }*/
        [TestMethod]
        public void addNewUserTest_ReturnEqual()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();
            int countBefore = filmsRecomend.accountsList.Count;
            int countAfter;
            filmsRecomend.addNewUser("admin", "vvv@gmail.com", "Sasha", "Ivanov");
            countAfter = filmsRecomend.accountsList.Count;
            countBefore += 1;
            Assert.AreEqual(countBefore, countAfter);


        }
        [TestMethod]
        public void addNewFilm_ReturnEqual()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();
            int countBefore = filmsRecomend.filmsList.Count;
            int countAfter;
            filmsRecomend.addNewFilm("Gorko 2", "plohoy", "comedy");
            countAfter = filmsRecomend.filmsList.Count;
            countBefore += 1;
            Assert.AreEqual(countBefore, countAfter);

        }
        [TestMethod]
        public void filmsRating_ReturnEqaul()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();
            int i = 1;
            filmsRecomend.filmsRatings(i);
            var x = filmsRecomend.ratingList[0];
            Assert.AreEqual(x, i);
        }
        [TestMethod]
        public void addNewFilmTestOnRightIndicators_ReturnEqual()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();
            filmsRecomend.addNewFilm("Gorko 2", "plohoy", "comedy");
            var Rightline = "Title:Gorko 2, Producer:plohoy, Genre:comedy";
            var Rightlineq = "Title:Gorko 2, Producer:plohoy, Genre:comedy";
            var line = (JsonConvert.SerializeObject(filmsRecomend.filmsList));
            Assert.AreEqual(Rightline, line);
        }
        [TestMethod]
        public void addNewUserTestOnRightIndicators_ReturnEqual()
        {
            FilmsRecommendationSystem filmsRecomend = new FilmsRecommendationSystem();
            filmsRecomend.addNewUser("admin", "vvv@gmail.com", "Sasha", "Ivanov");
            var Rightline = "Nickname:admin, Email: vvv@gmail.com, Name:Sasha, Surname:Ivanov";
            var line = (JsonConvert.SerializeObject(filmsRecomend.accountsList));
            Assert.AreEqual(Rightline, line);
        }



    }
}
