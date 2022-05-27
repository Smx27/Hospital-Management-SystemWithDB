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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DropAvDoctors.Clear();
            Getproblems();
        }

        private void DropAvDoctors_Click(object sender, EventArgs e)
        {
            GetDocname();
        }
        private void DropProblem_onItemSelected(object sender, EventArgs e)
        {
            DropAvDoctors.Clear();
            Insertdoocname(); 
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            InsertData();
            if(PaymentCheckBox.Checked==true)
            {
                Makebill();
            }
            clear_patientDetails();
        }
        #region Private functions
        /// <summary>
        /// if any value chacked in Doctor categorie docname will show up in that categorie
        /// </summary>
        void Insertdoocname()
        {
            try
            {
                BLLAddPatient obj = new BLLAddPatient();
                obj.Categorie = DropProblem.selectedValue;
                string dateTime = DateTime.Value.ToString("T");
                obj.Time = Convert.ToDateTime(dateTime);
                List<string> li = obj.GetDocName();
                foreach(string items in li)
                {
                    DropAvDoctors.AddItem(items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// this function loads doctors categories in from load
        /// </summary>
        void Getproblems()
        {
            try
            {
                BLLAddPatient obj = new BLLAddPatient();

                List<string> li = obj.Getproblems();
                foreach(string items in li)
                {
                    DropProblem.AddItem(items);                             
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// It assign Doctorname in Dropdown ritrived from DB
        /// </summary>
        void GetDocname()
        {
            try
            {
                BLLAddPatient obj = new BLLAddPatient();
                obj.Categorie = DropProblem.selectedValue; 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Submit all data in db 
        /// </summary>
        void InsertData()
        {
            try
            {
                BLLAddPatient obj = new BLLAddPatient();
                obj.Patientname = txtPatientName.Text;
                obj.Address = txtPatientAddress.Text;
                obj.Contact = txtPatientContact.Text;
                obj.Time = DateTime.Value.Date;
                obj.Problem = DropProblem.selectedValue;
                obj.Doctor = DropAvDoctors.selectedValue;
                obj.Categorie = DropProblem.selectedValue;
                if(PaymentCheckBox.Checked==true)
                {
                    obj.Payment = 1;
                }
                else
                {
                    obj.Payment = 0;
                }
                int row=obj.InsertData();
                if(row>0)
                {
                    MessageBox.Show("Data Added Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
            }
        }
        /// <summary>
        /// Create a bill according to details entered by someone
        /// </summary>
        void Makebill()
        {
            string Amount = "500";
            AppoinmentBill bill1 = new AppoinmentBill();
            bill1.Docname = DropAvDoctors.selectedValue;
            bill1.Categorie = DropProblem.selectedValue;
            bill1.Name= txtPatientName.Text;
            bill1.Contact = txtPatientContact.Text;
            bill1.Date = DateTime.Value.ToString("d");
            bill1.Amount = Amount;
            bill1.ShowDialog();
        }
        /// <summary>
        /// Crear All Textbox
        /// </summary>
        void clear_patientDetails()
        {
            this.txtPatientAddress.Text = "";
            this.txtPatientContact.Text = "";
            this.txtPatientName.Text = "";
            this.DropProblem.Clear();
            this.DropAvDoctors.Clear();
        }
        #endregion
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
        private void txtPatientName_OnValueChanged(object sender, EventArgs e)
        {
            this.Focus();
        }
        #endregion
    }
}
