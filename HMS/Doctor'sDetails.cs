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
    public partial class DoctorDetails : Form
    {
        public DoctorDetails()
        {
            InitializeComponent();
        }


        private void DoctorDetails_Load(object sender, EventArgs e)
        {
            loadDocCategories();
        }
        private void DropDocSec_onItemSelected(object sender, EventArgs e)
        {
            GetDocData();
        }
        #region Private FUnction
        /// <summary>
        /// Get Doc Categories from Table 
        /// </summary>
        private void loadDocCategories()
        {
            try
            {
                BLLDoocDetails details = new BLLDoocDetails();
                List<string> li=details.DocCategorie();
                foreach(string items in li)
                {
                    DropDocSec.AddItem(items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Get Doctor Details form Table following the condition
        /// </summary>
        private void GetDocData()
        {
            try
            {
                BLLDoocDetails obj = new BLLDoocDetails();
                obj.Categorie = DropDocSec.selectedValue;
                string dateTime = DateTime.Now.ToString("T");
                obj.Time =Convert.ToDateTime(dateTime);
                DataTable dt = obj.Doctordetais();
                if(dt.Rows.Count>0)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = dt;
                    DocView.DataSource = source;
                }
                else
                    MessageBox.Show("No Doc Avilable In " + DropDocSec.selectedValue + " Categorie"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
            }
        }
        #endregion
        #region Button Code
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnEmergancy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emargency obj = new Emargency();
            obj.Show();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashbord obj = new Dashbord();
            obj.ShowDialog();
        }

        private void btnbloodbank_Click(object sender, EventArgs e)
        {
            this.Close();
            BloodBank obj = new BloodBank();
            obj.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.Close();
            Appointment obj = new Appointment();
            obj.ShowDialog();
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Setting obj = new Setting();
            obj.ShowDialog();
        }
        #endregion
    }
}
