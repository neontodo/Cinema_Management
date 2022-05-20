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
    /// Summary description for WebAdmin
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebAdmin : System.Web.Services.WebService
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private DataSet workShiftsDataSet;
        private DataSet schedulesDataSet;
        private DataSet moviesDataSet;
        private DataSet reservationsDataSet;
        private DataSet employeesDataSet;

        [WebMethod(Description ="Returns all available information regarding all movies")]
        public List<string> GetAllMoviesDetails()
        {
            var movieDetails = new List<string>();

            InitializeDatabseConnection();

            var movies = moviesDataSet.Tables["Movies"].Rows;

            foreach(DataRow movie in movies)
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

                var currentMovieDetails = $"{currentMovieId};{currentMovieName};{currentMovieDirector};{currentMovieCast};{currentMovieDuration};{currentMovieGenre};{currentMoviePrice};{currentMovieRestrictions};{currentMovieDescription};{currentMovieRating};{currentMovieReleaseDate}";
                movieDetails.Add(currentMovieDetails);
            }

            return movieDetails;
        }

        [WebMethod(Description = "Makes an insertion into the database for a movie and all its details")]
        public bool AddMovie(List<string> details)
        {
            if (!details.Any())
            {
                return false;
            }

            var title = details.ElementAt(0);
            var director = details.ElementAt(1);
            var cast = details.ElementAt(2);
            var duration = details.ElementAt(3);
            var genre = details.ElementAt(4);
            var price = details.ElementAt(5);
            var restrictions = details.ElementAt(6);
            var description = details.ElementAt(7);
            var rating = details.ElementAt(8);
            var releaseDate = details.ElementAt(9);

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand add = new SqlCommand("INSERT INTO Movies (Title, Director, Cast, Duration, Genre, Price, Restrictions, Description, Rating, ReleaseDate) VALUES (@title, @director, @cast, @duration, @genre, @price, @restrictions, @description, @rating, @releaseDate)", sqlConnection);
            add.Parameters.AddWithValue("@title", title);
            add.Parameters.AddWithValue("@director", director);
            add.Parameters.AddWithValue("@cast", cast);
            add.Parameters.AddWithValue("@duration", duration);
            add.Parameters.AddWithValue("@genre", genre);
            add.Parameters.AddWithValue("@price", price);
            add.Parameters.AddWithValue("@restrictions", restrictions);
            add.Parameters.AddWithValue("@description", description);
            add.Parameters.AddWithValue("@rating", rating);
            add.Parameters.AddWithValue("@releaseDate", releaseDate);

            try
            {
                add.ExecuteNonQuery();
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

        [WebMethod(Description ="Modifies the details of a movie")]
        public bool UpdateMovie(List<string> details, int movieId)
        {
            if (!details.Any())
            {
                return false;
            }

            var title = details.ElementAt(0);
            var director = details.ElementAt(1);
            var cast = details.ElementAt(2);
            var duration = details.ElementAt(3);
            var genre = details.ElementAt(4);
            var price = details.ElementAt(5);
            var restrictions = details.ElementAt(6);
            var description = details.ElementAt(7);
            var rating = details.ElementAt(8);
            var releaseDate = details.ElementAt(9);

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand update = new SqlCommand("UPDATE Movies SET Title = @title, Director = @director, Cast = @cast, Duration = @duration, Genre = @genre, Price = @price, Restrictions = @restrictions, Description = @description, Rating = @rating, ReleaseDate = @releaseDate WHERE MovieId = @movieId", sqlConnection);
            update.Parameters.AddWithValue("@title", title);
            update.Parameters.AddWithValue("@director", director);
            update.Parameters.AddWithValue("@cast", cast);
            update.Parameters.AddWithValue("@duration", duration);
            update.Parameters.AddWithValue("@genre", genre);
            update.Parameters.AddWithValue("@price", price);
            update.Parameters.AddWithValue("@restrictions", restrictions);
            update.Parameters.AddWithValue("@description", description);
            update.Parameters.AddWithValue("@rating", rating);
            update.Parameters.AddWithValue("@releaseDate", releaseDate);
            update.Parameters.AddWithValue("@movieId", movieId);

            try
            {
                update.ExecuteNonQuery();
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

        [WebMethod(Description ="Deletes a single movie entry from the database")]
        public bool DeleteMovie(int movieId)
        {
            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand deleteFromReservations = new SqlCommand("DELETE FROM Reservations WHERE MovieId = @movieId", sqlConnection);
            SqlCommand eraseFromSchedules = new SqlCommand("UPDATE Schedules SET MovieId = NULL WHERE MovieId = @movieId");
            SqlCommand deleteFromMovies = new SqlCommand("DELETE FROM Movies WHERE MovieId = @movieId", sqlConnection);
            deleteFromReservations.Parameters.AddWithValue("@movieId", movieId);
            eraseFromSchedules.Parameters.AddWithValue("@movieId", movieId);
            deleteFromMovies.Parameters.AddWithValue("@movieId", movieId);

            try
            {
                deleteFromReservations.ExecuteNonQuery();
                eraseFromSchedules.ExecuteNonQuery();
                deleteFromMovies.ExecuteNonQuery();
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

        [WebMethod(Description ="Returns all shifts of the employees as well as their names")]
        public List<string> GetAllWorkShifts(int cinemaId)
        {
            var workShiftDetails = new List<string>();

            InitializeDatabseConnection();

            var workShifts = workShiftsDataSet.Tables["WorkShifts"].Rows;

            foreach (DataRow workShift in workShifts)
            {
                var currentShiftId = int.Parse(workShift.ItemArray[0].ToString());
                var currentShiftStartTime = workShift.ItemArray[1].ToString();
                var currentShiftDuration = int.Parse(workShift.ItemArray[2].ToString());
                var currentShiftEId = int.Parse(workShift.ItemArray[3].ToString());
                var currentShiftCinemaId = GetCinemaIdByEmployee(currentShiftEId);
                var currentShiftEmployeeName = GetEmployeeFullNameById(currentShiftEId);

                if(currentShiftCinemaId == cinemaId)
                {
                    var currentShiftDetails = $"{currentShiftId};{currentShiftStartTime};{currentShiftDuration};{currentShiftEmployeeName}";
                    workShiftDetails.Add(currentShiftDetails);
                }
            }
            return workShiftDetails;
        }

        [WebMethod(Description ="Makes an entry in the database for a workshift of an already existing employee")]
        public bool AddWorkShift(List<string> details)
        {
            if (!details.Any())
            {
                return false;
            }

            var startTime = details.ElementAt(0);
            var duration = details.ElementAt(1);
            var name = details.ElementAt(2);
            var eId = GetEmployeeIdByFullName(name);

            if(eId == -1)
            {
                return false;
            }

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand add = new SqlCommand("INSERT INTO WorkShifts (StartTime, Duration, EId) VALUES (@startTime, @duration, @eId)", sqlConnection);
            add.Parameters.AddWithValue("@startTime", startTime);
            add.Parameters.AddWithValue("@duration", duration);
            add.Parameters.AddWithValue("@eId", eId);

            try
            {
                add.ExecuteNonQuery();
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

        [WebMethod(Description ="Applies changes to the schedule held by an employee")]
        public bool UpdateWorkShift(List<string> details, int workShiftId)
        {
            if (!details.Any())
            {
                return false;
            }

            var startTime = details.ElementAt(0);
            var duration = details.ElementAt(1);
            var name = details.ElementAt(2);
            var eId = GetEmployeeIdByFullName(name);

            if (eId == -1)
            {
                return false;
            }

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand update = new SqlCommand("UPDATE WorkShifts SET StartTime = @startTime, Duration = @duration, EId = @eId WHERE ShiftId = @workShiftId", sqlConnection);
            update.Parameters.AddWithValue("@startTime", startTime);
            update.Parameters.AddWithValue("@duration", duration);
            update.Parameters.AddWithValue("@eId", eId);
            update.Parameters.AddWithValue("@workShiftId", workShiftId);

            try
            {
                update.ExecuteNonQuery();
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

        [WebMethod(Description ="Deletes the workshift of an employee")]
        public bool DeleteWorkShift(int workShiftId)
        {
            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand delete = new SqlCommand("DELETE FROM WorkShifts WHERE ShiftId = @workShiftId", sqlConnection);
            delete.Parameters.AddWithValue("@workShiftId", workShiftId);

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

        [WebMethod(Description ="Gets the entire schedule of a said cinema")]
        public List<string> GetAllSchedulesByCinema(int cinemaId)
        {
            var scheduleDetails = new List<string>();

            InitializeDatabseConnection();

            var schedules = schedulesDataSet.Tables["Schedules"].Rows;

            foreach (DataRow schedule in schedules)
            {
                var currentScheduleId = int.Parse(schedule.ItemArray[0].ToString());
                var currentScheduleMovieId = int.Parse(schedule.ItemArray[1].ToString());
                var currentScheduleTime = schedule.ItemArray[2].ToString();
                var currentScheduleWeekDay = schedule.ItemArray[3].ToString();
                var currentScheduleCinemaId = int.Parse(schedule.ItemArray[4].ToString());

                if (currentScheduleCinemaId == cinemaId)
                {
                    var currentScheduleDetails = $"{currentScheduleId};{currentScheduleMovieId};{currentScheduleTime};{currentScheduleWeekDay}";
                    scheduleDetails.Add(currentScheduleDetails);
                }
            }
            return scheduleDetails;
        }

        [WebMethod(Description ="Applies modifications to the schedule of a certain cinema")]
        public bool UpdateSchedules(List<string> details, int scheduleId)
        {
            if (!details.Any())
            {
                return false;
            }

            var movieId = details.ElementAt(0);
            var time = details.ElementAt(1);
            var weekDay = details.ElementAt(2);

            InitializeDatabseConnection();

            sqlConnection.Open();

            SqlCommand update = new SqlCommand("UPDATE Schedules SET MovieId = @movieId, Time = @time, Weekday = @weekDay WHERE ScheduleId = @scheduleId", sqlConnection);
            update.Parameters.AddWithValue("@movieId", movieId);
            update.Parameters.AddWithValue("@time", time);
            update.Parameters.AddWithValue("@weekDay", weekDay);
            update.Parameters.AddWithValue("@scheduleId", scheduleId);

            try
            {
                update.ExecuteNonQuery();
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

        private int GetCinemaIdByEmployee(int eId)
        {
            var cinemaId = -1;

            InitializeDatabseConnection();

            var employees = employeesDataSet.Tables["Employees"].Rows;

            foreach (DataRow employee in employees)
            {
                var currentEId = int.Parse(employee.ItemArray[0].ToString());
                var currentCinemaId = int.Parse(employee.ItemArray[7].ToString());

                if (currentEId == eId)
                {
                    cinemaId = currentCinemaId;
                    break;
                }
            }

            return cinemaId;
        }

        private string GetEmployeeFullNameById(int eId)
        {
            var name = "";
            
            InitializeDatabseConnection();

            var employees = employeesDataSet.Tables["Employees"].Rows;

            foreach (DataRow employee in employees)
            {
                var currentEId = int.Parse(employee.ItemArray[0].ToString());
                var currentName = employee.ItemArray[1].ToString();
                var currentSurname = employee.ItemArray[2].ToString();

                if (currentEId == eId)
                {
                    name = $"{currentName} {currentSurname}";
                    break;
                }
            }

            return name;
        }

        private int GetEmployeeIdByFullName(string name)
        {
            var id = -1;

            InitializeDatabseConnection();

            var employees = employeesDataSet.Tables["Employees"].Rows;

            foreach (DataRow employee in employees)
            {
                var currentEId = int.Parse(employee.ItemArray[0].ToString());
                var currentName = employee.ItemArray[1].ToString();
                var currentSurname = employee.ItemArray[2].ToString();
                var currentFullName = $"{currentName} {currentSurname}";

                if (currentFullName.Equals(name))
                {
                    id = currentEId;
                    break;
                }
            }

            return id;
        }

        [Description("Establishes the connection with the database")]
        private void InitializeDatabseConnection()
        {
            //sqlConnection.ConnectionString = @"Data Source=DESKTOP-9N4ISG2\MSSQLSERVER01;Initial Catalog=CinemaManagement;Integrated Security=True";
            sqlConnection.ConnectionString = @"Data Source=DESKTOP-B4VE8DR;Initial Catalog=CinemaManagement;Integrated Security=True";

            try
            {
                sqlConnection.Open();
                workShiftsDataSet = new DataSet();
                schedulesDataSet = new DataSet();
                moviesDataSet = new DataSet();
                reservationsDataSet = new DataSet();
                employeesDataSet = new DataSet();

                SqlDataAdapter workShiftsDataAdapter = new SqlDataAdapter("SELECT * FROM WorkShifts", sqlConnection);
                workShiftsDataAdapter.Fill(workShiftsDataSet, "WorkShifts");

                SqlDataAdapter schedulesDataAdapter = new SqlDataAdapter("SELECT * FROM Schedules", sqlConnection);
                schedulesDataAdapter.Fill(schedulesDataSet, "Schedules");

                SqlDataAdapter moviesDataAdapter = new SqlDataAdapter("SELECT * FROM Movies", sqlConnection);
                moviesDataAdapter.Fill(moviesDataSet, "Movies");

                SqlDataAdapter reservationsDataAdapter = new SqlDataAdapter("SELECT * FROM Reservations", sqlConnection);
                reservationsDataAdapter.Fill(reservationsDataSet, "Reservations");

                SqlDataAdapter employeesDataAdapter = new SqlDataAdapter("SELECT * FROM Employees", sqlConnection);
                employeesDataAdapter.Fill(employeesDataSet, "Employees");
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
