
namespace Project
{
    partial class Reservations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSearchByDay = new System.Windows.Forms.Button();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMovie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMovies = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReserve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBackR = new System.Windows.Forms.Button();
            this.buttonDeleteR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewReservations = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonSearchByDay);
            this.tabPage1.Controls.Add(this.numberOfSeatsTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonBack);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxMovie);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listBoxMovies);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.buttonReserve);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservations";
            // 
            // buttonSearchByDay
            // 
            this.buttonSearchByDay.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSearchByDay.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonSearchByDay.ForeColor = System.Drawing.Color.White;
            this.buttonSearchByDay.Location = new System.Drawing.Point(82, 93);
            this.buttonSearchByDay.Name = "buttonSearchByDay";
            this.buttonSearchByDay.Size = new System.Drawing.Size(88, 37);
            this.buttonSearchByDay.TabIndex = 13;
            this.buttonSearchByDay.Text = "Search Movie";
            this.buttonSearchByDay.UseVisualStyleBackColor = false;
            this.buttonSearchByDay.Click += new System.EventHandler(this.buttonSearchByDay_Click);
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(269, 314);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(193, 19);
            this.numberOfSeatsTextBox.TabIndex = 12;
            this.numberOfSeatsTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 18F);
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(264, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(371, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "Please select the number of seats:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBack.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(11, 358);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 35);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(82, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Search Movie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMovie
            // 
            this.textBoxMovie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxMovie.Location = new System.Drawing.Point(43, 250);
            this.textBoxMovie.Name = "textBoxMovie";
            this.textBoxMovie.Size = new System.Drawing.Size(193, 19);
            this.textBoxMovie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 18F);
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(6, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search movie by name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 18F);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(375, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please select the entry:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBoxMovies
            // 
            this.listBoxMovies.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxMovies.FormattingEnabled = true;
            this.listBoxMovies.Location = new System.Drawing.Point(269, 57);
            this.listBoxMovies.Name = "listBoxMovies";
            this.listBoxMovies.Size = new System.Drawing.Size(495, 212);
            this.listBoxMovies.TabIndex = 5;
            this.listBoxMovies.SelectedIndexChanged += new System.EventHandler(this.listBoxMovies_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonSearch.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(82, 162);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 37);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Details";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonReserve.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonReserve.ForeColor = System.Drawing.Color.White;
            this.buttonReserve.Location = new System.Drawing.Point(310, 346);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(88, 37);
            this.buttonReserve.TabIndex = 2;
            this.buttonReserve.Text = "Reserve";
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select the date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker.Location = new System.Drawing.Point(27, 57);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(209, 19);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.buttonBackR);
            this.tabPage2.Controls.Add(this.buttonDeleteR);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridViewReservations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservations List";
            // 
            // buttonBackR
            // 
            this.buttonBackR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonBackR.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonBackR.Location = new System.Drawing.Point(53, 347);
            this.buttonBackR.Name = "buttonBackR";
            this.buttonBackR.Size = new System.Drawing.Size(88, 35);
            this.buttonBackR.TabIndex = 11;
            this.buttonBackR.Text = "Back";
            this.buttonBackR.UseVisualStyleBackColor = false;
            this.buttonBackR.Click += new System.EventHandler(this.buttonBackR_Click);
            // 
            // buttonDeleteR
            // 
            this.buttonDeleteR.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDeleteR.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteR.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteR.Location = new System.Drawing.Point(340, 347);
            this.buttonDeleteR.Name = "buttonDeleteR";
            this.buttonDeleteR.Size = new System.Drawing.Size(88, 37);
            this.buttonDeleteR.TabIndex = 2;
            this.buttonDeleteR.Text = "Delete";
            this.buttonDeleteR.UseVisualStyleBackColor = false;
            this.buttonDeleteR.Click += new System.EventHandler(this.buttonDeleteR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 18F);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(50, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reservations:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridViewReservations
            // 
            this.dataGridViewReservations.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservations.Location = new System.Drawing.Point(53, 52);
            this.dataGridViewReservations.Name = "dataGridViewReservations";
            this.dataGridViewReservations.RowHeadersWidth = 51;
            this.dataGridViewReservations.Size = new System.Drawing.Size(665, 279);
            this.dataGridViewReservations.TabIndex = 0;
            this.dataGridViewReservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMovies;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewReservations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonBackR;
        private System.Windows.Forms.Button buttonDeleteR;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSearchByDay;
    }
}