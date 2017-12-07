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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoard
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_Load);

            panelMain.Location = panelLogin.Location;
           
        }

        // add login table adapter
        private LoginDataSetTableAdapters.UsersTableAdapter loginAdapter = new LoginDataSetTableAdapters.UsersTableAdapter();

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
            // when user clicks create asset we take them to the Assets form 
            Create c = new Create();
            c.Show();

        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            // when user clicks create a ticket we take them to the Tickets form
            Create c = new Create();
                c.Show();
        }

        private void tsQuit_Click(object sender, EventArgs e)
        {
            // close program
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticketsDataSet.Tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.ticketsDataSet.Tickets);

            hidePanels();
            panelLogin.Visible = true;
            panelLogin.Dock = DockStyle.Fill;
            menuStrip1.Hide();

        }

        public void hidePanels()
        {
            panelLogin.Visible = false;
            panelMain.Visible = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\Hoard.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE username = @username AND password = @password", con);
            cmd.Parameters.AddWithValue("@username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
            

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                panelLogin.Hide();
                panelMain.Show();
                panelMain.Dock = DockStyle.Fill;
                menuStrip1.Show();
                lblStatus.Text = "Welcome " + txtUsername.Text;
            }

            else
            {
                lblStatus.Text = "Please enter valid credentials";
                txtUsername.Clear();
                txtPassword.Clear();

            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.FillBy(this.ticketsDataSet.Tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        //toolstrip functions
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            t.Show();
        }

        private void assetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assets a = new Assets();
            a.Show();
        }
    }
}
