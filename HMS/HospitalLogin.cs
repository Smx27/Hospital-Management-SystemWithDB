using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BLL;

namespace HMS
{
    public partial class HospitalLogin : Form
    {
        public HospitalLogin()
        {
            InitializeComponent();
        }

        private void User_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            this.txtUsername.Text = "";
        }


        private void txtPassword_Click(object sender, EventArgs e)
        {
           this. txtPassword.Text = "";
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        } 
        /// <summary>
        /// this function login the user with right creadential
        /// </summary>
        void Login()
        {
            try
            {
                BLLLogin log = new BLLLogin();
                log.Username = txtUsername.Text;
                log.Password = txtPassword.Text;
                int check = log.Login();
                if (check == 1)
                {
                    this.Close();
                    Dashbord obj = new Dashbord();
                    obj.ShowDialog();
                }
                else
                    MessageBox.Show("Credentiel Error!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code " + ex.Message);
                throw;
            }
        }

    }
}
