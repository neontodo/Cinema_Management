
namespace Project
{
    partial class MoviesWorkSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesWorkSchedule));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonExitM = new System.Windows.Forms.Button();
            this.buttonUpdateM = new System.Windows.Forms.Button();
            this.buttonDeleteM = new System.Windows.Forms.Button();
            this.buttonInsertM = new System.Windows.Forms.Button();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExitS = new System.Windows.Forms.Button();
            this.buttonUpdateS = new System.Windows.Forms.Button();
            this.buttonDeleteS = new System.Windows.Forms.Button();
            this.buttonInsertS = new System.Windows.Forms.Button();
            this.dataGridViewShift = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonExitM);
            this.tabPage1.Controls.Add(this.buttonUpdateM);
            this.tabPage1.Controls.Add(this.buttonDeleteM);
            this.tabPage1.Controls.Add(this.buttonInsertM);
            this.tabPage1.Controls.Add(this.dataGridViewMovies);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Movies";
            // 
            // buttonExitM
            // 
            this.buttonExitM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExitM.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonExitM.Location = new System.Drawing.Point(685, 342);
            this.buttonExitM.Name = "buttonExitM";
            this.buttonExitM.Size = new System.Drawing.Size(80, 43);
            this.buttonExitM.TabIndex = 6;
            this.buttonExitM.Text = "Exit";
            this.buttonExitM.UseVisualStyleBackColor = false;
            this.buttonExitM.Click += new System.EventHandler(this.buttonExitM_Click);
            // 
            // buttonUpdateM
            // 
            this.buttonUpdateM.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonUpdateM.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateM.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateM.Location = new System.Drawing.Point(335, 329);
            this.buttonUpdateM.Name = "buttonUpdateM";
            this.buttonUpdateM.Size = new System.Drawing.Size(84, 36);
            this.buttonUpdateM.TabIndex = 5;
            this.buttonUpdateM.Text = "Update";
            this.buttonUpdateM.UseVisualStyleBackColor = false;
            this.buttonUpdateM.Click += new System.EventHandler(this.buttonUpdateM_Click);
            // 
            // buttonDeleteM
            // 
            this.buttonDeleteM.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDeleteM.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteM.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteM.Location = new System.Drawing.Point(471, 329);
            this.buttonDeleteM.Name = "buttonDeleteM";
            this.buttonDeleteM.Size = new System.Drawing.Size(84, 36);
            this.buttonDeleteM.TabIndex = 4;
            this.buttonDeleteM.Text = "Delete";
            this.buttonDeleteM.UseVisualStyleBackColor = false;
            this.buttonDeleteM.Click += new System.EventHandler(this.buttonDeleteM_Click);
            // 
            // buttonInsertM
            // 
            this.buttonInsertM.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonInsertM.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonInsertM.ForeColor = System.Drawing.Color.White;
            this.buttonInsertM.Location = new System.Drawing.Point(199, 329);
            this.buttonInsertM.Name = "buttonInsertM";
            this.buttonInsertM.Size = new System.Drawing.Size(84, 36);
            this.buttonInsertM.TabIndex = 3;
            this.buttonInsertM.Text = "Insert";
            this.buttonInsertM.UseVisualStyleBackColor = false;
            this.buttonInsertM.Click += new System.EventHandler(this.buttonInsertM_Click);
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.Size = new System.Drawing.Size(768, 310);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.buttonExitS);
            this.tabPage2.Controls.Add(this.buttonUpdateS);
            this.tabPage2.Controls.Add(this.buttonDeleteS);
            this.tabPage2.Controls.Add(this.buttonInsertS);
            this.tabPage2.Controls.Add(this.dataGridViewShift);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Work Shift";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // buttonExitS
            // 
            this.buttonExitS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExitS.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonExitS.Location = new System.Drawing.Point(685, 342);
            this.buttonExitS.Name = "buttonExitS";
            this.buttonExitS.Size = new System.Drawing.Size(80, 43);
            this.buttonExitS.TabIndex = 13;
            this.buttonExitS.Text = "Exit";
            this.buttonExitS.UseVisualStyleBackColor = false;
            this.buttonExitS.Click += new System.EventHandler(this.buttonExitS_Click);
            // 
            // buttonUpdateS
            // 
            this.buttonUpdateS.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonUpdateS.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonUpdateS.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateS.Location = new System.Drawing.Point(335, 329);
            this.buttonUpdateS.Name = "buttonUpdateS";
            this.buttonUpdateS.Size = new System.Drawing.Size(84, 36);
            this.buttonUpdateS.TabIndex = 12;
            this.buttonUpdateS.Text = "Update";
            this.buttonUpdateS.UseVisualStyleBackColor = false;
            this.buttonUpdateS.Click += new System.EventHandler(this.buttonUpdateS_Click);
            // 
            // buttonDeleteS
            // 
            this.buttonDeleteS.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonDeleteS.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteS.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteS.Location = new System.Drawing.Point(471, 329);
            this.buttonDeleteS.Name = "buttonDeleteS";
            this.buttonDeleteS.Size = new System.Drawing.Size(83, 36);
            this.buttonDeleteS.TabIndex = 11;
            this.buttonDeleteS.Text = "Delete";
            this.buttonDeleteS.UseVisualStyleBackColor = false;
            this.buttonDeleteS.Click += new System.EventHandler(this.buttonDeleteS_Click);
            // 
            // buttonInsertS
            // 
            this.buttonInsertS.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonInsertS.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonInsertS.ForeColor = System.Drawing.Color.White;
            this.buttonInsertS.Location = new System.Drawing.Point(199, 329);
            this.buttonInsertS.Name = "buttonInsertS";
            this.buttonInsertS.Size = new System.Drawing.Size(84, 36);
            this.buttonInsertS.TabIndex = 10;
            this.buttonInsertS.Text = "Insert";
            this.buttonInsertS.UseVisualStyleBackColor = false;
            this.buttonInsertS.Click += new System.EventHandler(this.buttonInsertS_Click);
            // 
            // dataGridViewShift
            // 
            this.dataGridViewShift.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShift.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShift.Name = "dataGridViewShift";
            this.dataGridViewShift.RowHeadersWidth = 51;
            this.dataGridViewShift.Size = new System.Drawing.Size(768, 312);
            this.dataGridViewShift.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.dataGridViewSchedule);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movie Schedule";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(685, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 18;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(335, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 36);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(768, 306);
            this.dataGridViewSchedule.TabIndex = 14;
            // 
            // MoviesWorkSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoviesWorkSchedule";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShift)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button buttonExitM;
        private System.Windows.Forms.Button buttonUpdateM;
        private System.Windows.Forms.Button buttonDeleteM;
        private System.Windows.Forms.Button buttonInsertM;
        private System.Windows.Forms.Button buttonExitS;
        private System.Windows.Forms.Button buttonUpdateS;
        private System.Windows.Forms.DataGridView dataGridViewShift;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDeleteS;
        private System.Windows.Forms.Button buttonInsertS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
    }
}