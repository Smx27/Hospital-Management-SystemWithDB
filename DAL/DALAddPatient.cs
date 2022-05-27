using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DALAddPatient
    {
        string _categorie;
        DateTime _time;
        string _patientname;
        string _address;
        string _contact;
        string _problem;
        string _doctor;
        int _payment;
        public string Categorie { get => _categorie; set => _categorie = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public string Patientname { get => _patientname; set => _patientname = value; }
        public string Address { get => _address; set => _address = value; }
        public string Contact { get => _contact; set => _contact = value; }
        public string Problem { get => _problem; set => _problem = value; }
        public string Doctor { get => _doctor; set => _doctor = value; }
        public int Payment { get => _payment; set => _payment = value; }

        /// <summary>
        /// this function takes a input of Doctor categorie
        /// </summary>
        /// <returns>It returns a list contaning Doctor name to that respen=cted categorie</returns>
        public List<string> GetDoctorname()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("DocName", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Dtype", _categorie);
            List<string> li = new List<string>();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    li.Add(rdr.GetString(0));
                }
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        /// <summary>
        /// This function insert data into DB
        /// </summary>
        /// <returns>A flag Is the data inserted successfully or not</returns>
        public int Insertpatientdata()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("AddPatient", con); //(@pDate, @PatientId, @PName, @PAddr, @PContact, @PDesies, @PDoc, @Payment
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pDate", _time);
            cmd.Parameters.AddWithValue("@PName", _patientname);
            cmd.Parameters.AddWithValue("@PAddr", _address);
            cmd.Parameters.AddWithValue("@PContact", _contact);
            cmd.Parameters.AddWithValue("@PDesies", _problem);
            cmd.Parameters.AddWithValue("@PDoc", _doctor);
            cmd.Parameters.AddWithValue("@Payment", _payment);
            try
            {
                con.Open();
                int roweffected = cmd.ExecuteNonQuery();
                return roweffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// This function get doctor name on respect to categorie
        /// </summary>
        /// <returns>Return List Of Doctor On selected Categorie</returns>
        public List<string> GetDocName()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd1 = new SqlCommand("DocName", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@Dtype", _categorie);
            cmd1.Parameters.AddWithValue("@dtime", _time);
            List<string> li = new List<string>();
            try
            {
                con.Open();
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                while (rdr1.Read())
                {
                    li.Add(rdr1.GetString(0));
                }
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
