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
using Bunifu.Charts;


namespace HMS
{
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }
        private void Dashbord_Load(object sender, EventArgs e)
        {
            ProgressBar();
            //Connecting With Data Base And Ritriving data
            chart();
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
            obj.Show();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            this.Hide();
            DoctorDetails obj = new DoctorDetails();
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
        #region Private Function
        /// <summary>
        /// Assign Progress bar values
        /// </summary>
        void ProgressBar()
        {
            //this.EmiestedPatients.Value = 60;     for referance only
            //EmiestedPatients.ProgressColor = Color.GreenYellow;
            try
            {
                BLLDashboord obj = new BLLDashboord();
                int data=obj.ProgressBarData();
                this.AvlDoctors.Value = data;

            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
            AvilBedPercentage();
        }
        /// <summary>
        /// This function assign the percentage of avilable bed progress bar
        /// </summary>
        void AvilBedPercentage()
        {
            //This Assign Avilable Doctors Percentage
            try
            {
                BLLDashboord obj = new BLLDashboord();
                int data=obj.AvilableDocPercentage();
                this.avlEmergencyBed.Value = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
        }
        /// <summary>
        /// It Assigns data To chart
        /// </summary>
        private void chart()
        {
            try
            {
                BLLDashboord obj = new BLLDashboord();
                DataTable dt=obj.ChartData();
                string[] Labels = new string[dt.Rows.Count];
                int index = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Labels[i] = dt.Rows[i][index].ToString();
                }
                List<double> Dat = new List<double>();
                foreach (DataRow row in dt.Rows)
                {
                    Dat.Add(Convert.ToDouble(row[1]));
                }
                bunifuLineChart1.Data = Dat;
                bunifuLineChart1.TargetCanvas = bunifuChartCanvas1;
                bunifuChartCanvas1.Labels = Labels;
                bunifuLineChart1.BackgroundColor = Color.GreenYellow;
            }
            catch (Exception ex)
            {
                MessageBox.Show("AHH!" + ex.Message);
                throw;
            }
        }
        #endregion
        private void MouseHoverOver(Button btnName)
        {
            btnName.FlatAppearance.BorderSize = 1;
            btnName.FlatAppearance.BorderColor = Color.Aqua;
            btnName.FlatAppearance.MouseOverBackColor = Color.BlueViolet;
            btnName.FlatAppearance.MouseDownBackColor = Color.Pink;
        }
        private void btnAddPAtient_MouseHover(object sender, EventArgs e)
        {
            MouseHoverOver(btnAddPAtient);
        }
    }
}
