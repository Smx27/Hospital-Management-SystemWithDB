using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class DALAppointment
    {
        string _DocCategorie;
        DateTime _time;
        string _docname;
        public string DocCategorie { get => _DocCategorie; set => _DocCategorie = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public string Docname { get => _docname; set => _docname = value; }

        /// <summary>
        /// Return a List Of Doctors Name Regarding the User Input
        /// </summary>
        public List<string> DropDocValueUpdate()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd1 = new SqlCommand("DocName", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            List<string> DropDoc = new List<string>();
            cmd1.Parameters.AddWithValue("@Dtype", _DocCategorie);
            cmd1.Parameters.AddWithValue("@Dtime", _time);
            try
            {
                con.Open();
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                while (rdr1.Read())
                {
                    DropDoc.Add(rdr1.GetString(0));
                }
                return DropDoc;
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
        /// Access the Db to Get Emergency Patient Details From Table RETURNS A DAtaset
        /// </summary>
        public DataSet EmergencyPatient()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter da = new SqlDataAdapter("EmergencyPatientAppoinmentDAta", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            // DataTable dt = new DataTable();
            //try
            //{
            //    con.Open();
            //    SqlDataReader rdr = cmd.ExecuteReader();
            //    BindingSource source = new BindingSource();
            //        while (rdr.Read())
            //        {
            //            source.DataSource = rdr;
            //            //DataGridAppoinments.DataSource = source;
            //            dt.Load(rdr);
            //        }
            //    return dt;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    con.Close();
            //}
            try
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Appoinment Data From Appoinment Table And Assign It In Data Grid and returns a Data table
        /// </summary>
        public DataTable DataGridAppionments()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetAppoinment", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DocName", _docname);
            cmd.Parameters.AddWithValue("@getDate", _time);
            DataTable dt = new DataTable();
            string Doc = _docname;
            SqlDataReader rdr = null;
            try
            {
                con.Open();
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                    //this.txtTotalPatients.Text = source.Count.ToString();
                }
                    return dt;
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
        /// This function returns Problems or the categories
        /// </summary>
        /// <returns>List Of Problem</returns>
        public List<string> Getproblems()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetProblem", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
    }
}
