using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Reservations(int cinemaId, int userId, Client client)
        {
            InitializeComponent();
            this.cinemaId = cinemaId;
            this.userId = userId;
            this.client = client;
            service = new ClientServiceReference.WebClientSoapClient();

            displayMovieDetailsByDate();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listBoxMovies.Items.Clear();
            displayMovieDetailsByDate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var selectedIndex = listBoxMovies.SelectedIndex;
            var selectedDetails = movieDetailsList.ElementAt(selectedIndex);
            var details = selectedDetails.Split(';');

            var movieName = details.ElementAt(0);
            var director = details.ElementAt(1);
            var cast = details.ElementAt(2);
            var duration = details.ElementAt(3);
            var genre = details.ElementAt(4);
            var price = details.ElementAt(5);
            var restrictions = details.ElementAt(6);
            var description = details.ElementAt(7);
            var rating = details.ElementAt(8);
            var releaseDate = DateTime.Parse(details.ElementAt(9)).ToShortDateString();
            var time = details.ElementAt(10);

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            client.Show();
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

            foreach(var movieDetails in movieDetailsList)
            {
                var details =  movieDetails.Split(';');
                var movieName = details.ElementAt(0);
                var movieDuration = details.ElementAt(3);
                var movieGenre = details.ElementAt(4);
                var movieTime = details.ElementAt(10);
                var relevantDetails = $"{movieName} - {movieDuration} min - {movieGenre} - {movieTime}";

                listBoxMovies.Items.Add(relevantDetails);
            }
        }

        private void buttonBackR_Click(object sender, EventArgs e)
        {
            client.Show();
            Close();
        }
    }
}
