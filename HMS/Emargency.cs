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
    public partial class Emargency : Form
    {
        public Emargency()
        {
            InitializeComponent();
        }


        public static string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        private void Emargency_Load(object sender, EventArgs e)
        {
            dropAvilableDoc.Clear();
            AddDropDocVal();
            AddDropAvilabelBedData();
            TextboxSource();//To Add Suggestion values in Search Bar
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ValueCheck();//This Function Check If Value Missing Then Insert It
        }
        private void droupAvilableBed_onItemSelected(object sender, EventArgs e)
        {
            AquairBed();//This Function Books Bed On someones Name Untill Discharge
        }
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            string message = "This Will Discharge Mr/Mrs. " + txtSearchPatient.Text + " Give Your Confermation";
            DialogResult res = MessageBox.Show(message, "Confirmation", btn);
            if(res==DialogResult.Yes)
            {
                Discharge();
            }
        }
        #region Private Function
        /// <summary>
        /// this function discharge patient by name.
        /// </summary>
        void Discharge()
        {
            try
            {
                BLLEmergency emr = new BLLEmergency();
                emr.Date = DateTime.Value.Date;
                emr.Name = txtSearchPatient.Text;
                int change = emr.Discharge();
                if (change > 0)
                {
                    MessageBox.Show("Discharge Of Mr/Mrs. " + txtSearchPatient.Text + " Is Done On " + DateTime.Value.Date + "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// This Returns The patient name who dont get discharge from hospital
        /// </summary>
        void TextboxSource()
        {
            txtSearchPatient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchPatient.AutoCompleteSource = AutoCompleteSource.CustomSource;
            try
            {
                BLLEmergency emergency = new BLLEmergency();
                AutoCompleteStringCollection col= emergency.SearchPatientName();
                txtSearchPatient.AutoCompleteCustomSource = col;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ahh! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// This Function Booked A bed Untill Patient Discharge
        /// </summary>
        void AquairBed()
        {
            try
            {
                BLLEmergency emergency = new BLLEmergency();
                emergency.Bedno = this.droupAvilableBed.selectedValue;
                int changes=emergency.AquairBed();
                if (changes > 0)
                {
                    MessageBox.Show("Bed Number " + droupAvilableBed.selectedValue + " Is Booked for " + txtName.Text + " Untill His/Her Discharge");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
            }
        }
        /// <summary>
        /// Get Doctors Name In Drop Down Menu 
        /// </summary>
        void AddDropDocVal()
        {
            try
            {
                BLLEmergency emr = new BLLEmergency();
                List<string> li = emr.AddDropDocVal();
                foreach(string item in li)
                {
                    dropAvilableDoc.AddItem(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Get Bed Details Of Freed Up Bed
        /// </summary>
        void AddDropAvilabelBedData()
        {
            try
            {
                BLLEmergency emr = new BLLEmergency();
                List<string> li = emr.AddDropAvilabelBedData();
                foreach(string item in li)
                {
                    droupAvilableBed.AddItem(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// This check If Any Mendetory is null or not
        /// </summary>
        void ValueCheck()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter A valid Name !");
            }
            else if (txtSex.Text == "")
                MessageBox.Show("Enter A Valid Gender");
            else if (txtAdmitedby.Text == "")
            {
                MessageBox.Show("This Name Is Mandatory");
            }
            else if (txtContactNum.Text == "")
                MessageBox.Show("This Information Is Mandatory");
            InsertData();
        }
        /// <summary>
        /// Inserting data to database
        /// </summary>
        void InsertData()
        {
            try
            {
                BLLEmergency obj = new BLLEmergency();
                obj.Admittedby = txtAdmitedby.Text;
                obj.Bedno = droupAvilableBed.selectedValue;
                obj.Bloodgrp = txtBloodGroup.Text;
                obj.Cause = txtCause.Text;
                obj.Contactno = txtContactNum.Text;
                obj.Date = DateTime.Value.Date;
                obj.Doctorname = dropAvilableDoc.selectedValue;
                obj.Pname = txtName.Text;
                obj.Sextype = txtSex.Text;
                int effectedrow = obj.InsertData();
                if(effectedrow>0)
                {
                    MessageBox.Show("Patient Admitted Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }

        #endregion
        #region Implimanted Button
        private void btnAddPAtient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient obj = new AddPatient();
            obj.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails obj = new DoctorDetails();
            obj.Show();
        }

        private void btnEmergancy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Emargency obj = new Emargency();
            obj.Show();
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
            Emargency obj = new Emargency();
            obj.Show();
        }

        #endregion

        
    }
}
