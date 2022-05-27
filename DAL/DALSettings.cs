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
    public class DALSettings
    {
        string _categorie;
        string _docname;
        string _oldpass;
        string _newpass;
        DateTime _time;
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Newpass { get => _newpass; set => _newpass = value; }
        public string Oldpass { get => _oldpass; set => _oldpass = value; }
        public string Docname { get => _docname; set => _docname = value; }
        public DateTime Time { get => _time; set => _time = value; }


        /// <summary>
        /// This function shows which doctors are absent
        /// </summary>
        /// <returns>return a Binding data source</returns>
        public BindingSource GetAbsentDoc()
        {
            String cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetAbsentDoctor", con);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                return source;
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
        /// Get Categorie data from DB
        /// </summary>
        /// <returns>Listt of string</returns>
        public List<string> GetCategorieData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetProblem", con);
            cmd.CommandType = CommandType.StoredProcedure;
            List<string> li = new List<string>(); ;
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
        /// Gives data to Doctor name on repect to categorie
        /// </summary>
        /// <returns>List of doc name</returns>
        public List<string> GetDocDetails()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd1 = new SqlCommand("AllDoc", con);
            cmd1.CommandType = CommandType.StoredProcedure;
            // string slv = DropProblem.selectedValue.ToString();
            cmd1.Parameters.AddWithValue("@Dtype", _categorie);
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
        /// <summary>
        /// This function Update password 
        /// </summary>
        /// <returns>a flag if the passchaanged or not</returns>
        public int UpdatePassword()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("ChangePassword", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@oldPassword", Oldpass);
            cmd.Parameters.AddWithValue("@newPassword", Newpass);
            try
            {
                con.Open();
                int changes = cmd.ExecuteNonQuery();
                return changes;
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
        public string switchValue()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            string Value = "0";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetPresentData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Categorie", _categorie);
            cmd.Parameters.AddWithValue("@Docname", _docname);
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Value = rdr["Avaibility"].ToString();
                }
                return Value;
            }
            catch (Exception)
            {
                MessageBox.Show("Something Unexpected Happend!");
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public int UpdateChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("GetChartData", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Date", _time);
            try
            {
                con.Open();
                int roweffected = cmd.ExecuteNonQuery();
                return roweffected;
            }
            catch (Exception ex )
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
