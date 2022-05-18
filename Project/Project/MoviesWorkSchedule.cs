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
    public partial class MoviesWorkSchedule : Form
    {
        private readonly int userId;
        private readonly First_Page first_Page;

        public MoviesWorkSchedule(int userId, First_Page first_Page)
        {
            InitializeComponent();
            this.userId = userId;
            this.first_Page = first_Page;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateS_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdateM_Click(object sender, EventArgs e)
        {

        }

        private void buttonExitM_Click(object sender, EventArgs e)
        {
            first_Page.Show();
            Close();
        }
    }
}
