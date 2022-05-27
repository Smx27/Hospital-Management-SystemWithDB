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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void BtnChartDataUpdate_Click(object sender, EventArgs e)//Update Chart Data 
        {
            UpdateChartData();//Not Implimented Chart
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            AddControll();
            GetCategorieData();
            GetAbsentDoc();
        }
        private void SwitchAbsentPresent_OnValueChange(object sender, EventArgs e)
        {
            int state = 0;
            if (SwitchAbsentPresent.Value == true)
            {
                state = 1;
            }
            UpdateSwitchData(state);
            GetAbsentDoc();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePassword();
        }//Update Password
        private void DropProblem_onItemSelected(object sender, EventArgs e)
        {
            DropDoctor.Clear();
            GetDoctorDetails();
        }
        private void DropDoctor_onItemSelected(object sender, EventArgs e)
        {
            SwitchValue();
        }
        #region Private Function
        /// <summary>
        /// Get Absent Doctor List into datagrid
        /// </summary>
        void GetAbsentDoc()
        {
            try
            {
                BLLSettings settings = new BLLSettings();
                BindingSource source = settings.GetAbsentDoc();
                DataGridAbsentDoctor.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Get Doctor Categories Data On From Load
        /// </summary>
        void GetCategorieData()
        {
            try
            {
                BLLSettings settings = new BLLSettings();
                List<string> li = settings.GetCategorieData();
                foreach(string item in li)
                {
                    DropProblem.AddItem(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Get Details of doctors on Droup Down Menu
        /// </summary>
        void GetDoctorDetails()
        {
            try
            {
                BLLSettings settings = new BLLSettings();
                settings.Categorie = DropProblem.selectedValue;
                List<string> li = settings.GetDocDetails();
                foreach(string item in li)
                {
                    DropDoctor.AddItem(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Update Login Password
        /// </summary>
        void UpdatePassword()
        {
            if (txtNewPas.Text != "" && txtOldPass.Text != "")
            {
                if (txtNewPas.Text == txtAgainNewPass.Text)
                {
                    string title = "Confirmation";
                    string Comment = "Do You Really Want to change Password?";
                    MessageBoxButtons btn = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(Comment, title, btn);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            BLLSettings settings = new BLLSettings();
                            settings.Oldpass = txtOldPass.Text;
                            settings.Newpass = txtNewPas.Text;
                            int flag = settings.UpdatePassword();
                            if (flag > 0)
                            {
                                MessageBox.Show("Password Updation Successfull!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("AHH! " + ex.Message);
                            throw;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Add Controlls In Tab Pages 
        /// </summary>
        void AddControll()
        {
            this.PageDoctorsAvibility.Controls.Add(this.label1);
            this.PageBesicSettings.Controls.Add(this.txtNewPas);
            this.PageBesicSettings.Controls.Add(this.txtOldPass);
            this.PageBesicSettings.Controls.Add(this.btnUpdate);
            this.PageBesicSettings.Controls.Add(this.lblDocSec);
            this.PageDoctorsAvibility.Controls.Add(this.label3);
            this.PageDoctorsAvibility.Controls.Add(this.label4);
            this.PageDoctorsAvibility.Controls.Add(this.label5);
            this.PageDoctorsAvibility.Controls.Add(this.guna2Separator1);
            this.PageDoctorsAvibility.Controls.Add(this.DropDoctor);
            this.PageDoctorsAvibility.Controls.Add(this.DropProblem);
            this.PageDoctorsAvibility.Controls.Add(this.DataGridAbsentDoctor);
            this.PageDoctorsAvibility.Controls.Add(this.SwitchAbsentPresent);
        }
        /// <summary>
        /// This Function On Or Of the Switch Collectiong data From Table
        /// </summary>
        void SwitchValue()
        {
            try
            {
                BLLSettings settings = new BLLSettings();
                settings.Categorie = DropProblem.selectedValue;
                settings.Docname = DropDoctor.selectedValue;
                string Value = settings.switchvalue();
                if (Value == "1")
                {
                    SwitchAbsentPresent.Value = true;
                }
                else
                    SwitchAbsentPresent.Value = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH! " + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// Update the doctor Avibility by turning on or off.
        /// </summary>
        void UpdateSwitchData(int state)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("TakePresentData", con);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@Docname", DropDoctor.selectedValue);
            cmd.Parameters.AddWithValue("@state", state);
            try
            {
                con.Open();
                int RowEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing Changed!\nSomeyhing Went Wrong!");
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Update Chart Info to database for Everyday Stat
        /// </summary>
        void UpdateChartData()
        {
            try
            {
                BLLSettings settings = new BLLSettings();
                settings.Time = DateTime.Value.Date;
                int change = settings.UpdateChartData();
                if(change>0)
                {
                    MessageBox.Show("Update Data Successfully!");
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
            MessageBox.Show("Under Construction");
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
