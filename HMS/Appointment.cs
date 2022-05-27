using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BLL;
namespace HMS
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }


        private void Appointment_Load(object sender, EventArgs e)//Loads Soctors from Selected Categories
        {
            this.txtTotalPatients.Text = "0";
            getproblem();
        }

        private void DropSection_onItemSelected(object sender, EventArgs e)//Loads Categories Of DOctors
        {
            DropDoctors.Clear();
            //DropDocValueUpdate();
            GetDropDocData();
        }
       

        private void DropDoctors_onItemSelected(object sender, EventArgs e)//Fill The Data Grid View 
        {
            SetRegularAppoinment();
        }
        private void SwicthChnageAppoinmet_CheckedChanged(object sender, EventArgs e)
        {
            if (SwicthChnageAppoinmet.Checked == true)
            {
                SetEmergencyData();
            }
            else if (DropDoctors.selectedIndex == -1 && DropSection.selectedIndex == -1)
            {
                MessageBox.Show("No Value Selected In droupdown!");
            }
            else
            {// touggle have to be fixed 
                SetRegularAppoinment();
            }
        }
        #region private functions
        /// <summary>
        /// This function Fill Problem data.
        /// </summary>
        private void getproblem()
        {
            BLLAppointment obj = new BLLAppointment();
            try
            {
                List<string> li=obj.GetProblem();
                foreach(string eliment in li)
                {
                    DropSection.AddItem(eliment);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! Error Found " + ex.Message);
            }
        }
        /// <summary>
        /// Returns List of Data to fill DropDown Menu
        /// </summary>
        private void GetDropDocData()
        {
            try
            {
                BLLAppointment bll = new BLLAppointment();
                bll.Doccategorie = DropSection.selectedValue;
                bll.Time = DateTime.Value;
                List<string> Docsec = bll.DocSecVal();
                foreach (string items in Docsec)
                {
                    DropDoctors.AddItem(items);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! Erroe Found "+ex.Message);
            }
        }//Data Layred Complete
        /// <summary>
        /// This function set the datagrid value with the data of Datatable 
        /// </summary>
        private void SetEmergencyData()
        {
            try
            {
                BLLAppointment obj = new BLLAppointment();
                DataSet ds = obj.GetemergancyData();
                if (ds.Tables.Count > 0)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = ds;
                    DataGridAppoinments.DataSource = source;
                }
                else
                    MessageBox.Show("No Patient In Emergency !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Set Regular Appoinment data
        /// </summary>
        private void SetRegularAppoinment()
        {
            try
            {
                BLLAppointment b1 = new BLLAppointment();
                b1.Docname = DropDoctors.selectedValue;
                b1.Time = DateTime.Value;
               DataTable dt= b1.Getregularpatient();
                if (dt.Rows.Count > 0)
                {
                    DataGridAppoinments.DataSource = dt;
                }
                else
                    MessageBox.Show("No Appointfound for Mr." + DropDoctors.selectedValue + " At this time");
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHHH! Error Happen" + ex.Message);
            }
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
        private void btnAboutus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Doge Infosis\n" +
                "Created By Sumit Maiti" +
                "\nAnd Swarup Das" +
                "\nDevloper Contact 9134560884/7001365015");
        }
        #endregion
    }
}
