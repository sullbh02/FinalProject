using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoard
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
            Load += new EventHandler(Tickets_Load);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Create f = new Hoard.Create();
            f.Show();
        }

        //serach the tickets based on location
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            Regex r = new Regex("^[a-zA-Z]+$");

            if (r.IsMatch(txtLocation.Text))
            {
               

                this.ticketsTableAdapter.SearchLocation(this.ticketsDataSet.Tickets, txtLocation.Text);

            }
            else
            {
                lblStatus.Text = "Please enter a valid location to search!";
                txtLocation.Clear();
            }
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.ticketsDataSet.Tickets);
           
        }

        // remove selected item 
        private void btnDelete_Click(object sender, EventArgs e)
        {
         foreach (DataGridViewRow item in this.dgvTickets.SelectedRows)
            {
                dgvTickets.Rows.RemoveAt(item.Index);
            }
        }
    }
}
