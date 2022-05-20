using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for WebClient
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebClient : System.Web.Services.WebService
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private DataSet reservationsDataSet;
        private DataSet cinemasDataSet;
        private DataSet schedulesDataSet;
        private DataSet moviesDataSet;

        [WebMethod(Description = "Makes a call to the database to have access to all cinemas available")]
        public List<string> GetAllCinemas()
        {
            List<string> cinemaLocations = new List<string>();

            InitializeDatabseConnection();

            var cinemas = cinemasDataSet.Tables["Cinemas"].Rows;

            foreach(DataRow cinema in cinemas)
            {
                var cinemaLocation = cinema.ItemArray[1].ToString();
                cinemaLocations.Add(cinemaLocation);
            }

            cinemaLocations.Sort();
            return cinemaLocations;
        }

        [WebMethod(Description = "Offers a reference(id) to the cinema in the region selected by the user")]
        public int GetCinemaByLocation(string cinemaLocation)
        {
            int cinemaId = -1;

            InitializeDatabseConnection();

            var cinemas = cinemasDataSet.Tables["Cinemas"].Rows;

            foreach (DataRow cinema in cinemas)
            {
                var currentCinemaLocation = cinema.ItemArray[1].ToString();

                if (cinemaLocation.Equals(currentCinemaLocation))
                {
                    cinemaId = int.Parse(cinema.ItemArray[0].ToString());
                    break;
                }
            }

            return cinemaId;
        }

        [WebMethod(Description = "Returns all movies available in the selected day")]
        public List<string> GetAllMoviesDetailsByDay(int cinemaId, string weekDay)
        {
            var availableMovies = new List<string>();

            InitializeDatabseConnection();

            var scheduleEntries = schedulesDataSet.Tables["Schedules"].Rows;

            foreach (DataRow scheduleEntry in scheduleEntries)
            {
                var currentScheduleCinemaId = int.Parse(scheduleEntry.ItemArray[4].ToString());
                var currentScheduleWeekDay = scheduleEntry.ItemArray[3].ToString();
                var currentScheduleMovieId = int.Parse(scheduleEntry.ItemArray[1].ToString());
                var currentScheduleTime = scheduleEntry.ItemArray[2].ToString();

                if (currentScheduleCinemaId == cinemaId && currentScheduleWeekDay.Equals(weekDay))
                {
                    var movieDetails = GetMovieDetailsById(currentScheduleMovieId);
                    movieDetails += ";" + currentScheduleTime;

                    availableMovies.Add(movieDetails);
                }
            }

            return availableMovies;
        }

        [WebMethod(Description = "Returns all details regarding a certain movie, searched by name")]
        public List<string> GetAllMoviesDetailsByName(int cinemaId, string name)
        {
            var detailsAndAvailableDates = new List<string>();

            InitializeDatabseConnection();

            var scheduleEntries = schedulesDataSet.Tables["Schedules"].Rows;

            foreach (DataRow scheduleEntry in scheduleEntries)
            {
                var currentScheduleCinemaId = int.Parse(scheduleEntry.ItemArray[4].ToString());
                var currentScheduleWeekDay = scheduleEntry.ItemArray[3].ToString();
                var currentScheduleMovieId = int.Parse(scheduleEntry.ItemArray[1].ToString());
                var currentScheduleTime = scheduleEntry.ItemArray[2].ToString();
                var currentScheduleMovieName = GetMovieNameById(currentScheduleMovieId);

                if (currentScheduleCinemaId == cinemaId && currentScheduleMovieName.Equals(name))
                {
                    var movieDetails = GetMovieDetailsById(currentScheduleMovieId);
                    var availableDate = currentScheduleTime + ";" + currentScheduleWeekDay;

                    detailsAndAvailableDates.Add(movieDetails + ";" + availableDate);
                }
            }

            return detailsAndAvailableDates;
        }

        [WebMethod(Description = "Makes an entry in the reservations table, containing references to the user, the cinema, the movie and its details")]
        public bool CreateReservation(List<string> details)
        {
            var userId = int.Parse(details.ElementAt(0));
            var cinemaId = int.Parse(details.ElementAt(1));
            var movieId = int.Parse(details.ElementAt(2));
            var time = DateTime.Parse(details.ElementAt(3));
            var numberOfSeats = int.Parse(details.ElementAt(4));

            if (IsNotAvailable(cinemaId, time, numberOfSeats))
            {
                return false; 
            }

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand createReservation = new SqlCommand("INSERT INTO Reservations (UserId, CinemaId, MovieId, Time, NumberOfSeats) VALUES (@userId, @cinemaId, @movieId, @time, @numberOfSeats)", sqlConnection);
            createReservation.Parameters.AddWithValue("@userId", userId);
            createReservation.Parameters.AddWithValue("@cinemaId", cinemaId);
            createReservation.Parameters.AddWithValue("@movieId", movieId);
            createReservation.Parameters.AddWithValue("@time", time);
            createReservation.Parameters.AddWithValue("@numberOfSeats", numberOfSeats);

            try
            {
                createReservation.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        [WebMethod(Description = "Makes a call and receives all entries regarding the existing reservations at that point in time")]
        public List<string> GetAllReservationsByUser(int userId)
        {
            var reservationList = new List<string>();

            InitializeDatabseConnection();

            var reservations = reservationsDataSet.Tables["Reservations"].Rows;

            foreach(DataRow reservation in reservations)
            {
                var currentReservationId = int.Parse(reservation.ItemArray[0].ToString());
                var currentReservationUserId = int.Parse(reservation.ItemArray[1].ToString());
                var currentReservationMovieId = int.Parse(reservation.ItemArray[3].ToString());
                var currentReservationTime = DateTime.Parse(reservation.ItemArray[4].ToString());
                var currentReservationNumberOfSeats = int.Parse(reservation.ItemArray[5].ToString());

                if(userId == currentReservationUserId && currentReservationTime > DateTime.Now)
                {
                    var movieName = GetMovieNameById(currentReservationMovieId);
                    var time = currentReservationTime.ToShortTimeString();
                    var date = currentReservationTime.ToLongDateString();

                    var resultEntry = $"{currentReservationId};{movieName};{date};{time};{currentReservationNumberOfSeats}";

                    reservationList.Add(resultEntry);
                }
            }

            return reservationList;
        }

        [WebMethod(Description ="Admins have the possibility to remove already existing reservations")]
        public bool DeleteReservation(int reservationId)
        {
            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand delete = new SqlCommand("DELETE FROM Reservations WHERE ReservationId = @reservationId", sqlConnection);
            delete.Parameters.AddWithValue("@reservationId", reservationId);

            try
            {
                delete.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        [Description("Checks wether the attempted reservation may be done, taking into consideration the number of seats left in the said cinema")]
        private bool IsNotAvailable(int cinemaId, DateTime time, int numberOfSeats)
        {
            var cinemaCapacity = GetCinemaCapacityById(cinemaId);
            var occupiedSeats = CountOccupiedSeats(cinemaId, time);
            var occupiedSeatsWithCurrentReservation = occupiedSeats + numberOfSeats;

            if(cinemaCapacity == -1 || cinemaCapacity < occupiedSeatsWithCurrentReservation)
            {
                return true;
            }

            return false;
        }

        [Description("Makes a call to the database and returns the maximum number of seats available for a cinema")]
        private int GetCinemaCapacityById(int cinemaId)
        {
            var capacity = -1;

            InitializeDatabseConnection();

            var cinemas = cinemasDataSet.Tables["Cinemas"].Rows;

            foreach(DataRow cinema in cinemas)
            {
                var currentCinemaId = int.Parse(cinema.ItemArray[0].ToString());
                var currentCinemaCapacity = int.Parse(cinema.ItemArray[2].ToString());

                if(currentCinemaId == cinemaId)
                {
                    capacity = currentCinemaCapacity;
                    break;
                }
            }

            return capacity;
        }

        [Description("Returns the remaining number of seata still available, taking into account all the reservations made")]
        private int CountOccupiedSeats(int cinemaId, DateTime time)
        {
            var occupiedSeats = 0;

            InitializeDatabseConnection();

            var reservations = reservationsDataSet.Tables["Reservations"].Rows;

            foreach (DataRow reservation in reservations)
            {
                var currentReservationCinemaId = int.Parse(reservation.ItemArray[2].ToString());
                var currentReservationTime = DateTime.Parse(reservation.ItemArray[4].ToString());
                var currentReservationNumberOfSeats = int.Parse(reservation.ItemArray[5].ToString());

                if(currentReservationCinemaId == cinemaId && currentReservationTime.Equals(time))
                {
                    occupiedSeats += currentReservationNumberOfSeats;
                }
            }

            return occupiedSeats;
        }

        [Description("Returns the name of the movie by using a reference to its id")]
        private string GetMovieNameById(int movieId)
        {
            string movieName = "";

            InitializeDatabseConnection();

            var movies = moviesDataSet.Tables["Movies"].Rows;

            foreach(DataRow movie in movies)
            {
                var currentMovieId = int.Parse(movie.ItemArray[0].ToString());
                var currentMovieName = movie.ItemArray[1].ToString();

                if(currentMovieId == movieId)
                {
                    movieName = currentMovieName;
                    break;
                }
            }

            return movieName;
        }

        private string GetMovieDetailsById(int movieId)
        {
            string movieDetails = "";

            InitializeDatabseConnection();

            var movies = moviesDataSet.Tables["Movies"].Rows;

            foreach (DataRow movie in movies)
            {
                var currentMovieId = int.Parse(movie.ItemArray[0].ToString());
                var currentMovieName = movie.ItemArray[1].ToString();
                var currentMovieDirector = movie.ItemArray[2].ToString();
                var currentMovieCast = movie.ItemArray[3].ToString();
                var currentMovieDuration = int.Parse(movie.ItemArray[4].ToString());
                var currentMovieGenre = movie.ItemArray[5].ToString();
                var currentMoviePrice = int.Parse(movie.ItemArray[6].ToString());
                var currentMovieRestrictions = movie.ItemArray[7].ToString();
                var currentMovieDescription = movie.ItemArray[8].ToString();
                var currentMovieRating = double.Parse(movie.ItemArray[9].ToString());
                var currentMovieReleaseDate = DateTime.Parse(movie.ItemArray[10].ToString());

                if (currentMovieId == movieId)
                {
                    movieDetails = $"{currentMovieId};{currentMovieName};{currentMovieDirector};{currentMovieCast};{currentMovieDuration};{currentMovieGenre};{currentMoviePrice};{currentMovieRestrictions};{currentMovieDescription};{currentMovieRating};{currentMovieReleaseDate}";
                    break;
                }
            }

            return movieDetails;
        }

        [Description("Establishes the connection with the database")]
        private void InitializeDatabseConnection()
        {
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-9N4ISG2\MSSQLSERVER01;Initial Catalog=CinemaManagement;Integrated Security=True";

            try
            {
                sqlConnection.Open();
                reservationsDataSet = new DataSet();
                cinemasDataSet = new DataSet();
                schedulesDataSet = new DataSet();
                moviesDataSet = new DataSet();

                SqlDataAdapter reservationsDataAdapter = new SqlDataAdapter("SELECT * FROM Reservations", sqlConnection);
                reservationsDataAdapter.Fill(reservationsDataSet, "Reservations");

                SqlDataAdapter cinemasDataAdapter = new SqlDataAdapter("SELECT * FROM Cinemas", sqlConnection);
                cinemasDataAdapter.Fill(cinemasDataSet, "Cinemas");

                SqlDataAdapter schedulesDataAdapter = new SqlDataAdapter("SELECT * FROM Schedules", sqlConnection);
                schedulesDataAdapter.Fill(schedulesDataSet, "Schedules");

                SqlDataAdapter moviesDataAdapter = new SqlDataAdapter("SELECT * FROM Movies", sqlConnection);
                moviesDataAdapter.Fill(moviesDataSet, "Movies");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
