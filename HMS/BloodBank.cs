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
    public partial class BloodBank : Form
    {
        public BloodBank()
        {
            InitializeComponent();
        }
        private void BloodBank_Load(object sender, EventArgs e)
        {

            BloodDetails();
        }
        void BloodDetails()
        {
            try
            {
                BLLBloodBank obj = new BLLBloodBank();
                DataTable dt = obj.BloodDetails();
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                AvailableBloodList.DataSource = source;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);

            }
        }

        #region Implimanted Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implimented Yet");
        }

        private void btnAddPAtient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient obj = new AddPatient();
            obj.ShowDialog();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails obj = new DoctorDetails();
            obj.ShowDialog();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashbord obj = new Dashbord();
            obj.ShowDialog();
        }

        private void btnbloodbank_Click(object sender, EventArgs e)
        {
            this.Hide();
            BloodBank obj = new BloodBank();
            obj.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment obj = new Appointment();
            obj.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            this.Hide();
            Setting obj = new Setting();
            obj.ShowDialog();
        }

        private void btnEmergancy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emargency obj = new Emargency();
            obj.Show();
        }
        #endregion        
    }
}
