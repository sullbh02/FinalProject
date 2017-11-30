using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoard
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            Load += new EventHandler(Create_Load);
        }

        //database

        private TicketsDataSetTableAdapters.TicketsTableAdapter ticketAdapter = new TicketsDataSetTableAdapters.TicketsTableAdapter();

        // form load

        private void Create_Load(object sender, EventArgs e)
        {
            ticketAdapter = new TicketsDataSetTableAdapters.TicketsTableAdapter();

        }

        // enabling of the group boxes based upon which checkbox is checked

        private void chkTicket_CheckedChanged(object sender, EventArgs e)
        {
            // if the Ticket is checked enable the Ticket groupbox
            if (chkTicket.Checked == true)
            {
                grbTicket.Enabled = true;
                chkAsset.Enabled = false;
            }
            // if Ticket is not checked disable group box
            else if (chkTicket.Checked == false)
            {
                grbTicket.Enabled = false;
                chkAsset.Enabled = true;
            }
           
        }

        private void chkAsset_CheckedChanged(object sender, EventArgs e)
        {
            // if the Asset is checked enable the Ticket groupbox
            if (chkAsset.Checked == true)
            {
                grbAsset.Enabled = true;
                chkTicket.Enabled = false;
            }
            // if Asset is not checked disable group box
            else if (chkAsset.Checked == false)
            {
                grbAsset.Enabled = false;
                chkTicket.Enabled = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // once the create button is clicked create a connection to the SQL database 
            string apPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

            
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Hoard.mdf;Integrated Security=True");
            if (chkTicket.Checked == true)
            {
                // write an INSERT statement for the Tickets table 
                string sqlTicket = "INSERT INTO Tickets (username, location, type, description) VALUES (@username, @location, @type, @description)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                con.Open();
                try
                {
  
                    using (SqlCommand cmd = new SqlCommand(sqlTicket, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtUser.Text);
                        cmd.Parameters.AddWithValue("@location", txtTicketLocation.Text);
                        cmd.Parameters.AddWithValue("@type", lstType.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.ExecuteNonQuery();
                        lblStatus.Text = "Ticket Created!";
                        txtUser.Clear();
                        txtTicketLocation.Clear();
                        lstType.ClearSelected();
                        txtDescription.Clear();

                    }
                }
                catch
                {
                    lblStatus.Text = "Ticket could not be created";
                }
               
                
            }
            else if (chkAsset.Checked == true)
            {
                // write an INSERT statemnet for the  Asset table 
                string sqlAsset = "INSERT INTO Assets (name, location, type, sn) VALUES (@name, @location, @type, @sn)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                con.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sqlAsset, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtAssetName.Text);
                        cmd.Parameters.AddWithValue("@location", txtAssetLocation.Text);
                        cmd.Parameters.AddWithValue("@type", lstAsset.Text);
                        cmd.Parameters.AddWithValue("@sn", txtSN.Text);
                        cmd.ExecuteNonQuery();
                        lblStatus.Text = "Asset added!";
                        txtAssetName.Clear();
                        txtAssetLocation.Clear();
                        lstAsset.ClearSelected();
                        txtSN.Clear();
                      

                    }
                }
                catch
                {
                    lblStatus.Text = "Asset could not be added.";
                }

            }
           con.Close();

        }
      

       
    }
}
