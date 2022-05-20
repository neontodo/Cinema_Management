//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ServiceTest
{
    [TestFixture]
    public class UnitAdminTest
    {
        ServiceReference3.WebAdminSoapClient service = new ServiceReference3.WebAdminSoapClient();
        [Test]
        public void GetAllMoviesDetails_ReceivesData()
        {
            List<string> movieDetails = new List<string>();

            movieDetails = service.GetAllMoviesDetails();

            Assert.IsNotEmpty(movieDetails);
        }

        [Test]
        public void GetAllMoviesDetails_AllData()
        {
            List<string> movieDetails = new List<string>();
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetails();
            details = movieDetails[1].Split(separator);

            Assert.AreEqual(details.Length, 11);
        }
        [Test]
        public void GetAllMoviesDetails_CorrectData()
        {
            List<string> movieDetails = new List<string>();
            char[] separator = new char[] { ';' };
            string[] details;

            movieDetails = service.GetAllMoviesDetails();
            details = movieDetails[0].Split(separator);

            Assert.AreEqual(details[1], "Gone Girl");
        }

        [Test]
        public void AddMovie_Succesful()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string title = "Test";
            string director = "Testimon";
            string cast = "Tests, Tests";
            string duration = "120";
            string genre = "horror test";
            string price = "15";
            string restrictions = "NR";
            string description = "Test Description";
            string rating = "8.3";
            string releaseDate = "2014-01-01";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.AddMovie(details);

            Assert.That(result, Is.True);
        }

        [Test]
        public void AddMovie_WrongRestriction()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string title = "Test";
            string director = "Testimon";
            string cast = "Tests, Tests";
            string duration = "120";
            string genre = "horror test";
            string price = "15";
            string restrictions = "Not a Restriction";
            string description = "Test Description";
            string rating = "8.3";
            string releaseDate = "2014-01-01";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.AddMovie(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void AddMovie_WrongIntegers()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string title = "Test";
            string director = "Testimon";
            string cast = "Tests, Tests";
            string duration = "Wrong";    //wrong
            string genre = "horror test";
            string price = "Wrong";    //wrong
            string restrictions = "NR";
            string description = "Test Description";
            string rating = "8.3";
            string releaseDate = "2014-01-01";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.AddMovie(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void AddMovie_Duplicate()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate for movie index 1
            string title = "Gone Girl";
            string director = "David Fincher";
            string cast = "Ben Affleck, Rosamund Pike, Neil Patrick Harris, Tyler Perry";
            string duration = "149";
            string genre = "Drama, Mystery, Thriller";
            string price = "24";
            string restrictions = "R";
            string description = "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.";
            string rating = "8.1";
            string releaseDate = "2014-01-01 00:00:00.000";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.AddMovie(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void UpdateMovie_Succesful()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate for movie index 1
            int movieId = 1;
            string title = "Gone Girl";
            string director = "David Fincher";
            string cast = "Ben Affleck, Rosamund Pike, Neil Patrick Harris, Tyler Perry";
            string duration = "149";
            string genre = "Drama, Mystery, Thriller";
            string price = "15";    //the value to be changes, 24 -> 15
            string restrictions = "R";
            string description = "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.";
            string rating = "8.1";
            string releaseDate = "2014-01-01 00:00:00.000";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.UpdateMovie(details, movieId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UpdateMovie_WrongDataType()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate for movie index 1
            int movieId = 1;
            string title = "Gone Girl";
            string director = "David Fincher";
            string cast = "Ben Affleck, Rosamund Pike, Neil Patrick Harris, Tyler Perry";
            string duration = "149";
            string genre = "Drama, Mystery, Thriller";
            string price = "Wrong";    //the value to be changes, 24 -> Wrong (int -> string)
            string restrictions = "R";
            string description = "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.";
            string rating = "8.1";
            string releaseDate = "2014-01-01 00:00:00.000";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            result = service.UpdateMovie(details, movieId);

            Assert.That(result, Is.False);
        }
        [Test]
        public void DeleteMovie_Succesful()
        {
            bool result=false;
            int movieId = 62;   //not auto-increment??
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string title = "Test";
            string director = "Testimon";
            string cast = "Tests, Tests";
            string duration = "120";
            string genre = "horror test";
            string price = "15";
            string restrictions = "NR";
            string description = "Test Description";
            string rating = "8.3";
            string releaseDate = "2014-01-01";

            details.Add(title);
            details.Add(director);
            details.Add(cast);
            details.Add(duration);
            details.Add(genre);
            details.Add(price);
            details.Add(restrictions);
            details.Add(description);
            details.Add(rating);
            details.Add(releaseDate);

            bool add = service.AddMovie(details);

            if(add == true) {
                result = service.DeleteMovie(movieId);
            }

            Assert.That(result, Is.True);
        }

        [Test]
        public void DeleteMovie_InexistentMovie()
        {
            bool result;
            int movieId = 1200;

            result = service.DeleteMovie(movieId);

            Assert.That(result, Is.False);
        }

        [Test]
        public void GetAllWorkShifts_ReceiveData()
        {
            List<string> workShiftDetails = new List<string>();
            int cinemaId = 9;

            workShiftDetails = service.GetAllWorkShifts(cinemaId);

            Assert.IsNotEmpty(workShiftDetails);
        }

        [Test]
        public void GetAllWorkShifts_CorrectData()
        {
            List<string> workShiftDetails = new List<string>();
            int cinemaId = 9;
            char[] separator = new char[] { ';' };
            string[] details;

            workShiftDetails = service.GetAllWorkShifts(cinemaId);
            details = workShiftDetails[0].Split(separator);

            Assert.AreEqual(details[3], "Mircea Lodoaba");
        }

        [Test]
        public void AddWorkShift_Succesful()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string startTime = "02:00:00";
            string duration = "4";
            string name = "Mircea Lodoaba";

            details.Add(startTime);
            details.Add(duration);
            details.Add(name);

            result = service.AddWorkShift(details);

            Assert.That(result, Is.True);
        }

        [Test]
        public void AddWorkShift_WrongData()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string startTime = "25:00:00";  //non-existent period of time
            string duration = "4";
            string name = "Mircea Lodoaba";

            details.Add(startTime);
            details.Add(duration);
            details.Add(name);

            result = service.AddWorkShift(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void AddWorkShift_IntersectShift()
        {
            bool result;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate shift
            string startTime = "08:00:00";
            string duration = "6";
            string name = "Mircea Lodoaba";

            details.Add(startTime);
            details.Add(duration);
            details.Add(name);

            result = service.AddWorkShift(details);

            Assert.That(result, Is.False);
        }

        [Test]
        public void UpdateWorkShift_Succesful()
        {
            bool result;
            int workShiftId = 17;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate shift
            string startTime = "04:00:00";  //08:00 -> 04:00
            string duration = "4";          //6 -> 4
            string name = "Mircea Lodoaba";

            details.Add(startTime);
            details.Add(duration);
            details.Add(name);

            result = service.UpdateWorkShift(details, workShiftId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UpdateWorkShift_WrongDataType()
        {
            bool result;
            int workShiftId = 17;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            //attempting duplicate shift
            string startTime = "not a time";  //08:00 -> not a time
            string duration = "test";          //6 -> test
            string name = "Mircea Lodoaba";

            details.Add(startTime);
            details.Add(duration);
            details.Add(name);

            result = service.UpdateWorkShift(details, workShiftId);

            Assert.That(result, Is.False);
        }

        [Test]
        public void DeleteWorkShift_Succesful()
        {
            int workShiftId = 44;
            bool result;

            result = service.DeleteWorkShift(workShiftId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void DeleteWorkShift_Inexistent()
        {
            int workShiftId = 1000;
            bool result;

            result = service.DeleteWorkShift(workShiftId);

            Assert.That(result, Is.False);
        }

        [Test]
        public void GetAllSchedulesByCinema_ReceivesData()
        {
            List<string> scheduleDetails = new List<string>();
            int cinemaId = 9;

            scheduleDetails = service.GetAllSchedulesByCinema(cinemaId);

            Assert.IsNotEmpty(scheduleDetails);
        }

        [Test]
        public void GetAllSchedulesByCinema_ReceivesAllData()
        {
            List<string> scheduleDetails = new List<string>();
            int cinemaId = 9;
            char[] separator = new char[] { ';' };
            string[] details;

            scheduleDetails = service.GetAllSchedulesByCinema(cinemaId);
            details = scheduleDetails[0].Split(separator);

            Assert.AreEqual(details.Length, 4);
        }
        [Test]
        public void GetAllSchedulesByCinema_CorrectData()
        {
            List<string> scheduleDetails = new List<string>();
            int cinemaId = 9;
            char[] separator = new char[] { ';' };
            string[] details;

            scheduleDetails = service.GetAllSchedulesByCinema(cinemaId);
            details = scheduleDetails[0].Split(separator);

            Assert.AreEqual(details[3], "Monday");
        }

        [Test]
        public void UpdateSchedule_Succesful()
        {
            bool result;
            int scheduleId = 1;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string movieId = "1";
            string time = "13:00:00";   //08:00 -> 13:00
            string weekDay = "Monday";

            details.Add(movieId);
            details.Add(time);
            details.Add(weekDay);

            result = service.UpdateSchedules(details, scheduleId);

            Assert.That(result, Is.True);
        }

        [Test]
        public void UpdateSchedule_WrongDataType()
        {
            bool result;
            int scheduleId = 1;
            ServiceReference3.ArrayOfString details = new ServiceReference3.ArrayOfString();
            string movieId = "1";
            string time = "08:00:00";
            string weekDay = "14";   //Monday -> 14

            details.Add(movieId);
            details.Add(time);
            details.Add(weekDay);

            result = service.UpdateSchedules(details, scheduleId);

            Assert.That(result, Is.False);
        }
    }
}
