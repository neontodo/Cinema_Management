using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class Reservations : Form
    {
        private readonly int cinemaId;
        private readonly int userId;
        private readonly Client client;
        private readonly ClientServiceReference.WebClientSoapClient service;
        private List<string> movieDetailsList;
        private List<string> reservationsList;
        private bool searchedByName = false;
        private int confirmFlag;

        public Reservations(int cinemaId, int userId, Client client)
        {
            InitializeComponent();
            this.cinemaId = cinemaId;
            this.userId = userId;
            this.client = client;
            service = new ClientServiceReference.WebClientSoapClient();
            confirmFlag = -1;

            dataGridViewReservations.Columns.Add("movieTitle", "Movie title");
            dataGridViewReservations.Columns[0].Width = 325;
            dataGridViewReservations.Columns.Add("date", "Date");
            dataGridViewReservations.Columns[1].Width = 165;
            dataGridViewReservations.Columns.Add("time", "Time");
            dataGridViewReservations.Columns[2].Width = 45;
            dataGridViewReservations.Columns.Add("numberOfSeats", "Number of seats");
            dataGridViewReservations.Columns[3].Width = 75;
            displayMovieDetailsByDate();
            displayAllReservations();
        }

        public void SetConfirmFlag(int state)
        {
            confirmFlag = state;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            client.Show();
            base.OnFormClosing(e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxMovies.SelectedIndex;
            var numberOfEntries = movieDetailsList.Count;

            if (listBoxMovies.SelectedItem != null)
            {
                var selectedDetails = movieDetailsList.ElementAt(selectedIndex % numberOfEntries);
                var details = selectedDetails.Split(';');

                var movieName = details.ElementAt(1);
                var director = details.ElementAt(2);
                var cast = details.ElementAt(3);
                var duration = details.ElementAt(4);
                var genre = details.ElementAt(5);
                var price = details.ElementAt(6);
                var restrictions = details.ElementAt(7);
                var description = details.ElementAt(8);
                var rating = details.ElementAt(9);
                var releaseDate = DateTime.Parse(details.ElementAt(10)).ToShortDateString();
                var time = details.ElementAt(11);

                var message = $"Title: {movieName}\n";
                message += $"Director: {director}\n";
                message += $"Cast: {cast}\n";
                message += $"Duration: {duration} min\n";
                message += $"Genre: {genre}\n";
                message += $"Price: {price} $\n";
                message += $"Restrictions: {restrictions}\n";
                message += $"Description: {description}\n";
                message += $"Rating: {rating}\n";
                message += $"Release date: {releaseDate}\n";
                message += $"Schedule: {time}\n";

                MessageBox.Show(message, "Info");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayMovieDetailsByDate()
        {
            var weekDay = dateTimePicker.Value.DayOfWeek.ToString();
            movieDetailsList = service.GetAllMoviesDetailsByDay(cinemaId, weekDay);

            foreach (var movieDetails in movieDetailsList)
            {
                var details = movieDetails.Split(';');
                var movieName = details.ElementAt(1);
                var movieDuration = details.ElementAt(4);
                var movieGenre = details.ElementAt(5);
                var movieTime = details.ElementAt(11);
                var relevantDetails = $"{movieName} - {movieDuration} min - {movieGenre} - {movieTime}";

                listBoxMovies.Items.Add(relevantDetails);
            }
        }

        private void displayMovieDetailsByName()
        {
            var movieName = textBoxMovie.Text;
            movieDetailsList = service.GetAllMoviesDetailsByName(cinemaId, movieName);

            for (DateTime date = DateTime.Today; date.Month == DateTime.Today.Month; date = date.AddDays(1))
            {
                foreach (var movieDetails in movieDetailsList)
                {
                    var details = movieDetails.Split(';');
                    var movieDuration = details.ElementAt(5);
                    var movieGenre = details.ElementAt(6);
                    var moviePrice = details.ElementAt(7);
                    var movieTime = details.ElementAt(11);
                    var movieWeekDay = details.ElementAt(12);

                    if (date.DayOfWeek.ToString().Equals(movieWeekDay))
                    {
                        var relevantDetails = $"{date.ToLongDateString()} - {movieDuration} min - {movieGenre} - {moviePrice} - {movieTime}";

                        listBoxMovies.Items.Add(relevantDetails);
                    }
                }
            }

            if (listBoxMovies.Items.Count == 0)
            {
                MessageBox.Show("The movie with the given name does not exist.", "Error!");
            }
        }

        private void buttonBackR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
            displayMovieDetailsByName();

            searchedByName = true;
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if(dateTimePicker.Value < DateTime.Now)
            {
                MessageBox.Show("The selected date is not valid.", "Error!");
            }
            else if (numberOfSeatsTextBox.Text != "")
            {
                var del = new ConfirmActionDelegate(executeAfterCreationConfirmation);

                var confirmAction = new ConfirmAction(null, null, this, del);
                confirmAction.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please specify the number of seats.", "Error!");
            }
        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchedByName)
            {
                var selectedItem = listBoxMovies.SelectedItem.ToString();
                var details = selectedItem.Split('-');
                var date = DateTime.Parse(details.ElementAt(0));

                dateTimePicker.Value = date;
            }
        }

        private void buttonSearchByDay_Click(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
            displayMovieDetailsByDate();

            searchedByName = false;
        }

        private void executeAfterCreationConfirmation()
        {
            if(confirmFlag == 1)
            {
                var selectedIndex = listBoxMovies.SelectedIndex;
                var detailsCount = movieDetailsList.Count;
                var details = movieDetailsList.ElementAt(selectedIndex % detailsCount).Split(';');
                var movieId = details.ElementAt(0);
                var time = dateTimePicker.Value.ToShortDateString() + " " + details.ElementAt(11);
                var numberOfSeats = numberOfSeatsTextBox.Text;

                var reservationDetails = new ClientServiceReference.ArrayOfString
                {
                    userId.ToString(),
                    cinemaId.ToString(),
                    movieId,
                    time,
                    numberOfSeats
                };

                if (service.CreateReservation(reservationDetails))
                {
                    MessageBox.Show("Reservation created successfully.", "Success!");
                    dataGridViewReservations.Rows.Clear();
                    displayAllReservations();
                }
                else
                {
                    MessageBox.Show("An error occured (number of seats must be a positive integer).", "Error!");
                }

                confirmFlag = -1;
            }
            
            if(confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            numberOfSeatsTextBox.Text = "";
        }

        private void executeAfterDeletionConfirmation()
        {
            if (confirmFlag == 1)
            {
                var reservationDetails = reservationsList.ElementAt(dataGridViewReservations.CurrentCell.RowIndex);
                var reservationId = int.Parse(reservationDetails.Split(';').ElementAt(0));

                if (service.DeleteReservation(reservationId))
                {
                    MessageBox.Show("Reservation deleted successfully.", "Success!");
                    dataGridViewReservations.Rows.Clear();
                    displayAllReservations();
                }
                else
                {
                    MessageBox.Show("An error occurred. Please try again.", "Error!");
                }

                confirmFlag = -1;
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }
        }

        private void displayAllReservations()
        {
            reservationsList = service.GetAllReservationsByUser(userId);

            foreach (var reservation in reservationsList)
            {
                var details = reservation.Split(';');
                var movieName = details.ElementAt(1);
                var date = details.ElementAt(2);
                var time = details.ElementAt(3);
                var numberOfSeats = details.ElementAt(4);

                dataGridViewReservations.Rows.Add(movieName, date, time, numberOfSeats);
            }
        }

        private void buttonDeleteR_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dataGridViewReservations.CurrentCell.RowIndex;

            if(selectedRowIndex != -1)
            {
                var del = new ConfirmActionDelegate(executeAfterDeletionConfirmation);

                var confirmAction = new ConfirmAction(null, null, this, del);
                confirmAction.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
        }
    }
}
