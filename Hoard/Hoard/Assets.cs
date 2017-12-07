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
    public partial class Assets : Form
    {
        public Assets()
        {
            InitializeComponent();
            Load += new EventHandler(Assets_Load);
        }

        // take user to create a asset
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Create c = new Create();
            c.Show();
         
        }

        private void Assets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetsDataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.assetsDataSet.Assets);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";

            Regex r = new Regex("^[a-zA-Z]+$");

            if (r.IsMatch(txtSearch.Text))
            { 

                // based upon how the user wants to search for assets we walk thru the case statement 
                switch (cbSearch.SelectedIndex)
                {
                case 0:
                    // sql Name
                    this.assetsTableAdapter.SearchName(this.assetsDataSet.Assets, txtSearch.Text);
                    break;

                case 1:
                    //sql Loc
                    this.assetsTableAdapter.SearchLocation(this.assetsDataSet.Assets, txtSearch.Text);
                    break;

                case 2:
                    //sql type
                    this.assetsTableAdapter.SearchType(this.assetsDataSet.Assets, txtSearch.Text);
                    break;

            }
        }
            else
            {
                lblStatus.Text = "Please enter a valid search, words only please.";
                txtSearch.Clear();
            }
        }
    }
}
