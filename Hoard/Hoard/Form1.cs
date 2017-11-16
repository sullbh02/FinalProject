/*
 * Ben Sullivan 
 * Semester Project - Hoard
 * An application that will create and store tickets in a database.  Also the application will allow for assest tracking by storing assests in a database.
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsTicketsForm_Click(object sender, EventArgs e)
        {
            // show tickets form
            Tickets ticketsForm = new Tickets();
            ticketsForm.Show();
        }

        private void tsAssetsForm_Click(object sender, EventArgs e)
        {
            // show assets form
            Assets assestsForm = new Hoard.Assets();
            assestsForm.Show();
        }

        private void btnNewAsset_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {

        }

        private void tsQuit_Click(object sender, EventArgs e)
        {
            // close program
            Application.Exit();
        }
    }
}
