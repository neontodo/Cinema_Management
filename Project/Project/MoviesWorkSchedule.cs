using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class MoviesWorkSchedule : Form
    {
        private readonly int userId;
        private readonly int cinemaId;
        private readonly First_Page first_Page;
        private readonly AdminServiceReference.WebAdminSoapClient service;
        private List<string> moviesList;
        private List<string> shiftsList;
        private List<string> scheduleList;
        private int confirmFlag;

        public MoviesWorkSchedule(int userId, First_Page first_Page)
        {
            InitializeComponent();
            service = new AdminServiceReference.WebAdminSoapClient();
            this.userId = userId;
            cinemaId = service.GetCinemaIdByUserId(userId);
            this.first_Page = first_Page;
            confirmFlag = -1;

            initializeDataGridViewMovies();
            initializeDataGridViewShifts();
            initializeDataGridViewSchdule();
        }

        public void SetConfirmFlag(int state)
        {
            confirmFlag = state;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            first_Page.Show();
            base.OnFormClosing(e);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateS_Click(object sender, EventArgs e)
        {
            var entryIndex = dataGridViewMovies.CurrentCell.RowIndex;

            if (entryIndex == -1)
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
            else
            {
                var del = new ConfirmActionDelegate(executeAfterShiftUpdateConfirmation);

                var confirmAction = new ConfirmAction(null, this, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void buttonUpdateM_Click(object sender, EventArgs e)
        {
            var entryIndex = dataGridViewMovies.CurrentCell.RowIndex;

            if (entryIndex == -1)
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
            else
            {
                var del = new ConfirmActionDelegate(executeAfterMovieUpdateConfirmation);

                var confirmAction = new ConfirmAction(null, this, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void buttonExitM_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonInsertM_Click(object sender, EventArgs e)
        {
            var del = new ConfirmActionDelegate(executeAfterMovieInsertConfirmation);

            var confirmAction = new ConfirmAction(null, this, null, del);
            confirmAction.Show();
            Hide();
        }

        private void buttonDeleteM_Click(object sender, EventArgs e)
        {
            var entryIndex = dataGridViewMovies.CurrentCell.RowIndex;

            if (entryIndex == -1)
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
            else
            {
                var del = new ConfirmActionDelegate(executeAfterMovieDeleteConfirmation);

                var confirmAction = new ConfirmAction(null, this, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void buttonInsertS_Click(object sender, EventArgs e)
        {
            var del = new ConfirmActionDelegate(executeAfterShiftInsertConfirmation);

            var confirmAction = new ConfirmAction(null, this, null, del);
            confirmAction.Show();
            Hide();
        }

        private void buttonDeleteS_Click(object sender, EventArgs e)
        {
            var entryIndex = dataGridViewShift.CurrentCell.RowIndex;

            if (entryIndex == -1)
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
            else
            {
                var del = new ConfirmActionDelegate(executeAfterShiftDeleteConfirmation);

                var confirmAction = new ConfirmAction(null, this, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void buttonExitS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var entryIndex = dataGridViewSchedule.CurrentCell.RowIndex;

            if (entryIndex == -1)
            {
                MessageBox.Show("Please select a row first.", "Error!");
            }
            else
            {
                var del = new ConfirmActionDelegate(executeAfterScheduleUpdateConfirmation);

                var confirmAction = new ConfirmAction(null, this, null, del);
                confirmAction.Show();
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initializeDataGridViewMovies()
        {
            dataGridViewMovies.Columns.Add("movieId", "Movie ID");
            dataGridViewMovies.Columns[0].Width = 80;
            dataGridViewMovies.Columns.Add("name", "Movie title");
            dataGridViewMovies.Columns[1].Width = 150;
            dataGridViewMovies.Columns.Add("director", "Director");
            dataGridViewMovies.Columns[2].Width = 120;
            dataGridViewMovies.Columns.Add("cast", "Cast");
            dataGridViewMovies.Columns[3].Width = 200;
            dataGridViewMovies.Columns.Add("duration", "Duration");
            dataGridViewMovies.Columns[4].Width = 80;
            dataGridViewMovies.Columns.Add("genre", "Genre");
            dataGridViewMovies.Columns[5].Width = 150;
            dataGridViewMovies.Columns.Add("price", "Price");
            dataGridViewMovies.Columns[6].Width = 60;
            dataGridViewMovies.Columns.Add("restrictions", "Restrictions");
            dataGridViewMovies.Columns[7].Width = 90;
            dataGridViewMovies.Columns.Add("description", "Description");
            dataGridViewMovies.Columns[8].Width = 130;
            dataGridViewMovies.Columns.Add("rating", "Rating");
            dataGridViewMovies.Columns[9].Width = 60;
            dataGridViewMovies.Columns.Add("releaseDate", "Release date");
            dataGridViewMovies.Columns[10].Width = 75;

            displayMoviesDetails();
        }

        private void initializeDataGridViewShifts()
        {
            dataGridViewShift.Columns.Add("startTime", "Starting time");
            dataGridViewShift.Columns[0].Width = 240;
            dataGridViewShift.Columns.Add("duration", "Work hours");
            dataGridViewShift.Columns[1].Width = 240;
            dataGridViewShift.Columns.Add("name", "Employee name");
            dataGridViewShift.Columns[2].Width = 240;

            displayShiftsDetails();
        }

        private void initializeDataGridViewSchdule()
        {
            dataGridViewSchedule.Columns.Add("movieId", "Movie ID");
            dataGridViewSchedule.Columns[0].Width = 150;
            dataGridViewSchedule.Columns.Add("time", "Starting hour");
            dataGridViewSchedule.Columns[1].Width = 275;
            dataGridViewSchedule.Columns.Add("weekDay", "Day of week");
            dataGridViewSchedule.Columns[2].Width = 275;

            displayScheduleDetails();
        }

        private void displayMoviesDetails()
        {
            moviesList = service.GetAllMoviesDetails();

            foreach (var movieDetails in moviesList)
            {
                var details = movieDetails.Split(';');

                var movieId = details.ElementAt(0);
                var movieName = details.ElementAt(1);
                var director = details.ElementAt(2);
                var cast = details.ElementAt(3);
                var duration = details.ElementAt(4);
                var genre = details.ElementAt(5);
                var price = details.ElementAt(6);
                var restrictions = details.ElementAt(7);
                var description = details.ElementAt(8);
                var rating = details.ElementAt(9);
                var releaseDate = details.ElementAt(10);

                dataGridViewMovies.Rows.Add(movieId, movieName, director, cast, duration, genre, price, restrictions, description, rating, releaseDate);
            }
        }

        private void displayShiftsDetails()
        {
            shiftsList = service.GetAllWorkShifts(cinemaId);

            foreach (var shiftDetails in shiftsList)
            {
                var details = shiftDetails.Split(';');

                var startTime = details.ElementAt(1);
                var duration = details.ElementAt(2);
                var employeeName = details.ElementAt(3);

                dataGridViewShift.Rows.Add(startTime, duration, employeeName);
            }
        }

        private void displayScheduleDetails()
        {
            scheduleList = service.GetAllSchedulesByCinema(cinemaId);

            foreach (var scheduleDetails in scheduleList)
            {
                var details = scheduleDetails.Split(';');

                var movieId = details.ElementAt(1);
                var time = details.ElementAt(2);
                var weekDay = details.ElementAt(3);

                dataGridViewSchedule.Rows.Add(movieId, time, weekDay);
            }
        }

        private void executeAfterMovieInsertConfirmation()
        {
            if (confirmFlag == 1)
            {
                var lastEntryId = dataGridViewMovies.Rows.Count - 2;
                var insertedName = dataGridViewMovies.Rows[lastEntryId].Cells[1].Value.ToString();
                var insertedDirector = dataGridViewMovies.Rows[lastEntryId].Cells[2].Value.ToString();
                var insertedCast = dataGridViewMovies.Rows[lastEntryId].Cells[3].Value.ToString();
                var insertedDuration = dataGridViewMovies.Rows[lastEntryId].Cells[4].Value.ToString();
                var insertedGenre = dataGridViewMovies.Rows[lastEntryId].Cells[5].Value.ToString();
                var insertedPrice = dataGridViewMovies.Rows[lastEntryId].Cells[6].Value.ToString();
                var insertedRestrictions = dataGridViewMovies.Rows[lastEntryId].Cells[7].Value.ToString();
                var insertedDescription = dataGridViewMovies.Rows[lastEntryId].Cells[8].Value.ToString();
                var insertedRating = dataGridViewMovies.Rows[lastEntryId].Cells[9].Value.ToString();
                var insertedReleaseDate = dataGridViewMovies.Rows[lastEntryId].Cells[10].Value.ToString();

                var details = new AdminServiceReference.ArrayOfString
                {
                    insertedName,
                    insertedDirector,
                    insertedCast,
                    insertedDuration,
                    insertedGenre,
                    insertedPrice,
                    insertedRestrictions,
                    insertedDescription,
                    insertedRating,
                    insertedReleaseDate
                };

                if (service.AddMovie(details))
                {
                    MessageBox.Show("Movie added successfully.", "Success!");
                }
                else
                {
                    MessageBox.Show("An error occurred (invalid data formats).", "Error!");
                }

                confirmFlag = -1;
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewMovies.Rows.Clear();
            displayMoviesDetails();
        }

        private void executeAfterMovieUpdateConfirmation()
        {
            if (confirmFlag == 1)
            {
                var entryIndex = dataGridViewMovies.CurrentCell.RowIndex;
                if (entryIndex < dataGridViewMovies.RowCount - 1)
                {
                    var movieId = int.Parse(dataGridViewMovies.Rows[entryIndex].Cells[0].Value.ToString());
                    var insertedName = dataGridViewMovies.Rows[entryIndex].Cells[1].Value.ToString();
                    var insertedDirector = dataGridViewMovies.Rows[entryIndex].Cells[2].Value.ToString();
                    var insertedCast = dataGridViewMovies.Rows[entryIndex].Cells[3].Value.ToString();
                    var insertedDuration = dataGridViewMovies.Rows[entryIndex].Cells[4].Value.ToString();
                    var insertedGenre = dataGridViewMovies.Rows[entryIndex].Cells[5].Value.ToString();
                    var insertedPrice = dataGridViewMovies.Rows[entryIndex].Cells[6].Value.ToString();
                    var insertedRestrictions = dataGridViewMovies.Rows[entryIndex].Cells[7].Value.ToString();
                    var insertedDescription = dataGridViewMovies.Rows[entryIndex].Cells[8].Value.ToString();
                    var insertedRating = dataGridViewMovies.Rows[entryIndex].Cells[9].Value.ToString();
                    var insertedReleaseDate = dataGridViewMovies.Rows[entryIndex].Cells[10].Value.ToString();

                    var details = new AdminServiceReference.ArrayOfString
                    {
                    insertedName,
                    insertedDirector,
                    insertedCast,
                    insertedDuration,
                    insertedGenre,
                    insertedPrice,
                    insertedRestrictions,
                    insertedDescription,
                    insertedRating,
                    insertedReleaseDate
                    };

                    if (service.UpdateMovie(details, movieId))
                    {
                        MessageBox.Show("Movie updated successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred (invalid data formats).", "Error!");
                    }

                    confirmFlag = -1;
                }
                else
                {
                    MessageBox.Show("Please try updating an already existing row");
                }
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewMovies.Rows.Clear();
            displayMoviesDetails();
        }

        private void executeAfterMovieDeleteConfirmation()
        {
            if (confirmFlag == 1)
            {
                var entryIndex = dataGridViewMovies.CurrentCell.RowIndex;
                if (entryIndex < dataGridViewMovies.RowCount - 1)
                {
                    var movieId = int.Parse(dataGridViewMovies.Rows[entryIndex].Cells[0].Value.ToString());

                    if (service.DeleteMovie(movieId))
                    {
                        MessageBox.Show("Movie deleted successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred (movie not found).", "Error!");
                    }

                    confirmFlag = -1;
                }
                else
                {
                    MessageBox.Show("Please select a valid row", "Error!");
                }
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }


            dataGridViewMovies.Rows.Clear();
            displayMoviesDetails();
        }

        private void executeAfterShiftInsertConfirmation()
        {
            if (confirmFlag == 1)
            {
                var lastEntryId = dataGridViewShift.Rows.Count - 2;
                var insertedStartTime = dataGridViewShift.Rows[lastEntryId].Cells[0].Value.ToString();
                var insertedDuration = dataGridViewShift.Rows[lastEntryId].Cells[1].Value.ToString();
                var insertedEmployeeName = dataGridViewShift.Rows[lastEntryId].Cells[2].Value.ToString();

                var details = new AdminServiceReference.ArrayOfString
                {
                    insertedStartTime,
                    insertedDuration,
                    insertedEmployeeName
                };

                if (service.AddWorkShift(details))
                {
                    MessageBox.Show("Shift added successfully.", "Success!");
                }
                else
                {
                    MessageBox.Show("An error occurred. Possible causes may be:\n  - Invalid data format\n  - Employee already has a shift", "Error!");
                }

                confirmFlag = -1;
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewShift.Rows.Clear();
            displayShiftsDetails();
        }

        private void executeAfterShiftUpdateConfirmation()
        {
            if (confirmFlag == 1)
            {
                var entryIndex = dataGridViewShift.CurrentCell.RowIndex;
                if (entryIndex < dataGridViewShift.RowCount - 1)
                {
                    var shiftId = int.Parse(shiftsList.ElementAt(entryIndex).Split(';').ElementAt(0));
                    var insertedStartTime = dataGridViewShift.Rows[entryIndex].Cells[0].Value.ToString();
                    var insertedDuration = dataGridViewShift.Rows[entryIndex].Cells[1].Value.ToString();
                    var insertedEmployeeName = dataGridViewShift.Rows[entryIndex].Cells[2].Value.ToString();

                    var details = new AdminServiceReference.ArrayOfString
                    {
                    insertedStartTime,
                    insertedDuration,
                    insertedEmployeeName
                    };

                    if (service.UpdateWorkShift(details, shiftId))
                    {
                        MessageBox.Show("Shift updated successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred An error occurred. Possible causes may be:\n  - Invalid data format\n  - Employee already has a shift.", "Error!");
                    }

                    confirmFlag = -1;
                }
                else
                {
                    MessageBox.Show("Please update an already existing raw");
                }
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewShift.Rows.Clear();
            displayShiftsDetails();
        }

        private void executeAfterShiftDeleteConfirmation()
        {
            if (confirmFlag == 1)
            {
                var entryIndex = dataGridViewShift.CurrentCell.RowIndex;
                if (entryIndex < dataGridViewShift.RowCount - 1)
                {
                    var shiftId = int.Parse(shiftsList.ElementAt(entryIndex).Split(';').ElementAt(0));

                    if (service.DeleteWorkShift(shiftId))
                    {
                        MessageBox.Show("Work shift deleted successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred (movie not found).", "Error!");
                    }

                    confirmFlag = -1;
                }
                else
                {
                    MessageBox.Show("Please select a valid row", "Error!");
                }
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewShift.Rows.Clear();
            displayShiftsDetails();
        }

        private void executeAfterScheduleUpdateConfirmation()
        {
            if (confirmFlag == 1)
            {
                var entryIndex = dataGridViewSchedule.CurrentCell.RowIndex;
                if (entryIndex < dataGridViewSchedule.RowCount - 1)
                {
                    var scheduleId = int.Parse(scheduleList.ElementAt(entryIndex).Split(';').ElementAt(0));
                    var insertedMovieId = dataGridViewSchedule.Rows[entryIndex].Cells[0].Value.ToString();
                    var insertedTime = dataGridViewSchedule.Rows[entryIndex].Cells[1].Value.ToString();
                    var insertedWeekDay = dataGridViewSchedule.Rows[entryIndex].Cells[2].Value.ToString();

                    var details = new AdminServiceReference.ArrayOfString
                    {
                    insertedMovieId,
                    insertedTime,
                    insertedWeekDay
                    };

                    if (service.UpdateSchedules(details, scheduleId))
                    {
                        MessageBox.Show("Schedule updated successfully.", "Success!");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred An error occurred (invalid data format).", "Error!");
                    }

                    confirmFlag = -1;
                }
                else
                {
                    MessageBox.Show("Please try updating an already existing row");
                }
            }

            if (confirmFlag == 0)
            {
                MessageBox.Show("Operation cancelled.", "Success!");

                confirmFlag = -1;
            }

            dataGridViewSchedule.Rows.Clear();
            displayScheduleDetails();
        }
    }
}
