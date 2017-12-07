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
using System.Net.Mail;
using System.Net;

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


        // this function will send an e-mail to the Technican if a ticket is created. 
        public string sendit(string ReciverMail)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("githubprogramtester@gmail.com ");
            msg.To.Add(ReciverMail);
            msg.Subject = "A ticket has been created @ " + DateTime.Now.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Name: " + txtUser.Text);
            sb.AppendLine("Description: " + txtDescription.Text);
            msg.Body = sb.ToString();
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("githubprogramtester@gmail.com ", "mattPARKER292");
            client.Timeout = 20000;

            //after getting information from textboxes clear all selections on form
            txtUser.Clear();
            txtTicketLocation.Clear();
            lstType.ClearSelected();
            txtDescription.Clear();

            try
            {
                client.Send(msg);
                return "Mail has been successfully sent!";
              

            }
            catch (Exception ex)
            {
                return "Fail Has error" + ex.Message;
            }
            finally
            {
                msg.Dispose();
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
                        
                        // this is our techs e-mail (githubprogramtester@gmail.com)  
                        // if a ticket is succesfully created send an e-mail.

                        sendit("githubprogramtester@gmail.com ");
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
                        Assets a = new Assets();
                        a.Refresh();

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
