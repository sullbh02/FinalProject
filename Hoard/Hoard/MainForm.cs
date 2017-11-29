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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Load += new EventHandler(Form1_Load);
            InitializeComponent();
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

        }

        private void btnNewTicket_Click(object sender, EventArgs e)
        {
            // when user clicks create a ticket we take them to the Tickets form

        }

        private void tsQuit_Click(object sender, EventArgs e)
        {
            // close program
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //on form load fill the form with the login panel
            panelLogin.Dock = DockStyle.Fill;

            //Hide the main panel until the user has succesfully logged in
            panelMain.Hide();
            this.AcceptButton = btnLogin;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //vars for the login panel
            string username = "";
            string password = "";
            bool validUser = false;
            bool validPass = false;
           

            // check if the user entered a valid username

            if (txtUsername.Text.Length > 0)
            {
             
                validUser = true;
            }
            else
            {
                lblStatus.Text = "Please enter a valid username";
            }

            // check for a valid password

            if(txtPassword.Text.Length > 0)
            {
                         validPass = true;
            }
            else
            {
                lblStatus.Text = "Pleas enter a valid password";
            }

            //if both the username and password are valid continue
            if(validUser == true && validPass == true)
            {
                txtPassword.Text = password;
                txtUsername.Text = username;
                try
                {
                    // check if the username and password combo is in our database
                    if(loginAdapter.Search(loginAdapter.GetData(), username, password) > 0)
                    {
                        // hide the login panel and display the main panel
                        panelLogin.Hide();
                        panelMain.Show();
                        panelMain.Dock = DockStyle.Fill;
                        this.AcceptButton = null;
                        txtPassword.Clear();
                        txtUsername.Clear();
                    }
                    // if the combo is invalid search for username in database
                    else if(loginAdapter.SearchUsername(loginAdapter.GetData(), username) > 0)
                    {
                        // if username is found inform user of an invalid password
                        lblStatus.Text = "Invalid password";
                    }
                    // if username is not found inform user of invalid crendtials
                    else
                    {
                        lblStatus.Text = "Invalid credentials";
                    }
                }
                catch
                {
                    lblStatus.Text = "Error logging in";
                }
            }



        }
    }
}
