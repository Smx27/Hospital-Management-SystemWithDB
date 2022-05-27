using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;

namespace DAL
{
    public class DALDocDetail
    {
        string _categorie;
        DateTime _time;
        public string Categorie { get => _categorie; set => _categorie = value; }
        public DateTime Time { get => _time; set => _time = value; }

        /// <summary>
        /// Set Docname on The Load Of Application
        /// </summary>
        /// <returns>List Of doctors name</returns>
        public List<string> DocCategorie()
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
        /// <summary>
        /// This Function Shows The Doctorsdetails in Grid view
        /// </summary>
        /// <returns>returns a Data Table</returns>
        public DataTable DoctorDetails()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetDocDetail", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DocType", _categorie);
            cmd.Parameters.AddWithValue("@Dtime", _time);
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
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
    }
}
