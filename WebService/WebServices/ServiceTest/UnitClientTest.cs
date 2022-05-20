//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceTest
{
    [TestFixture]
    public class UnitClientTest
    {
        ServiceReference2.WebClientSoapClient service = new ServiceReference2.WebClientSoapClient();
        [Test]
        public void GetAllCinemas_Succesful_NotEmpty()
        {
            List<string> cinemas = new List<string>();
            cinemas = service.GetAllCinemas();

            Assert.IsNotEmpty(cinemas);
        }

        [Test]
        public void GetAllCinemas_Succesful_RightOrder()
        {
            List<string> cinemas = new List<string>();
            cinemas = service.GetAllCinemas();
            string firstCinema = cinemas.ElementAt(0);

            Assert.AreEqual(firstCinema, "Alba Iulia");
        }

        [Test]
        public void GetCinemaByLocation_RightId()
        {
            int id;
            string cinemaLocation = "Alba Iulia";

            id = service.GetCinemaByLocation(cinemaLocation);

            Assert.AreEqual(id, 9);
        }

        [Test]
        public void GetCinemaByLocation_NonExistentLocation()
        {
            int id;
            string cinemaLocation = "Paris";

            id = service.GetCinemaByLocation(cinemaLocation);

            Assert.AreEqual(id, -1);
        }

        [Test]
        public void GetCinemaByLocation_NullEntry()
        {

        }

        [Test]
        public void GetAllMoviesByDay_ReceivesData()
        {
            List<string> movieDetails = new List<string>();
            int cinemaId = 9;
            string weekDay = "Monday";

            movieDetails = service.GetAllMoviesDetailsByDay(cinemaId, weekDay);

            Assert.IsNotEmpty(movieDetails);
        }

        //TO BE SEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEN
        [Test]
        public void GetAllMoviesByDay_ReceivesAllData()
        {
            int i = 0;
            List<string> movieDetails = new List<string>();
            int cinemaId = 9;
            string weekDay = "Monday";
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetailsByDay(cinemaId, weekDay);
            details = movieDetails[1].Split(separator);

            string smth = details[10];

            Assert.AreEqual(smth, "");

            //Assert.AreEqual(details.Length, 10);
        }
        [Test]
        public void GetAllMoviesByDay_ReceivesCorrectData()
        {
            int i = 0;
            List<string> movieDetails = new List<string>();
            int cinemaId = 9;
            string weekDay = "Monday";
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetailsByDay(cinemaId, weekDay);
            details = movieDetails[0].Split(separator);

            Assert.AreEqual(details[0], "Spider-Man: Homecoming");
        }

        [Test]
        public void GetAllMoviesDetailsByName_AllData()
        {
            int i = 0;
            List<string> movieDetails = new List<string>();
            int cinemaId = 9;
            string name = "Spider-Man: Homecoming";
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetailsByName(cinemaId, name);
            details = movieDetails[0].Split(separator);

            string smth = details[10];

            Assert.AreEqual(smth, "");

            Assert.AreEqual(details.Length, 10);
        }

        [Test]
        public void GetAllMoviesDetailsByName_CorrectData()
        {
            List<string> movieDetails = new List<string>();
            int cinemaId = 9;
            string name = "Spider-Man: Homecoming";
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetailsByName(cinemaId, name);
            details = movieDetails[0].Split(separator);

            Assert.AreEqual(details[0], "Spider-Man: Homecoming");
        }

        [Test]
        public void CreateReservations_Succesful()
        {
            bool result;
            ServiceReference2.ArrayOfString details = new ServiceReference2.ArrayOfString();
            string userId = "55";
            string cinemaId = "9";
            string movieId = "19";
            string time = "2022-05-20 4:00:00.000";
            string numberOfSeats = "49";

            details.Add(userId);
            details.Add(cinemaId);
            details.Add(movieId);
            details.Add(time);
            details.Add(numberOfSeats);

            result = service.CreateReservation(details);

            Assert.That(result, Is.True);
        }

        [Test]
        public void CreateReservations_NotEnoughSeats()
        {
            bool result;
            ServiceReference2.ArrayOfString details = new ServiceReference2.ArrayOfString();
            string userId = "55";
            string cinemaId = "9";
            string movieId = "19";
            string time = "2022-04-18 14:00:00.000";
            string numberOfSeats = "13";  //adding over the already taken 155 seats, having cinema with capacity 155

            details.Add(userId);
            details.Add(cinemaId);
            details.Add(movieId);
            details.Add(time);
            details.Add(numberOfSeats);

            result = service.CreateReservation(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void GetAllReservationsByUser_ReceivesData()
        {
            List<string> reservationsUser = new List<string>();
            int userId = 45;

            reservationsUser = service.GetAllReservationsByUser(userId);

            Assert.IsNotEmpty(reservationsUser);
        }

        [Test]
        public void GetAllReservationsByUser_CorrectData()
        {
            List<string> reservationsUser = new List<string>();
            int userId = 45;
            char[] separator = new char[] { ';' };
            string[] details;

            reservationsUser = service.GetAllReservationsByUser(userId);
            details = reservationsUser[0].Split(separator);

            Assert.AreEqual(details[1], "Gone Girl");

        }

        [Test]
        public void GetAllReservationsByUser_NoReservation()
        {
            List<string> reservationsUser = new List<string>();
            int userId = 51;

            reservationsUser = service.GetAllReservationsByUser(userId);

            Assert.IsEmpty(reservationsUser);

        }

        [Test]
        public void GetAllReservationsByUser_OldReservationsOnly()
        {
            List<string> reservationsUser = new List<string>();
            int userId = 47;

            reservationsUser = service.GetAllReservationsByUser(userId);

            Assert.IsEmpty(reservationsUser);
        }

        [Test]
        public void DeleteReservation_Succesful()
        {
            bool result;
            int reservationId=10;

            result = service.DeleteReservation(reservationId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void DeleteReservation_NoReservation()
        {
            bool result;
            int reservationId = 11;

            result = service.DeleteReservation(reservationId);

            Assert.That(result, Is.False);
        }
    }
}
