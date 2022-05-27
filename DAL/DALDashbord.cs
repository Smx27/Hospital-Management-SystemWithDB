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
    public class DALDashbord
    {
        /// <summary>
        /// It Update Progress bar data
        /// </summary>
        /// <returns>It returns int data</returns>
        public int ProgressbarData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("countDoctorPresent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            int Data = 0;
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Data = Convert.ToInt32(rdr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            double res = Data * 4.34;
            return Convert.ToInt32(res);
        }
        /// <summary>
        /// This function returns Avilable bed data
        /// </summary>
        /// <returns>Return a percentage of avilable bed</returns>
        public int AvilableBedPercentage()
        {
            string cs=ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("countAvilableBeds", con);
            cmd.CommandType = CommandType.StoredProcedure;
            int data2 = 0;
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    data2 = Convert.ToInt32(rdr[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            double res1 = data2 * 9.09;
            return Convert.ToInt32(res1);
        }
        

        /// <summary>
        /// This function Returns data of chart 
        /// </summary>
        /// <returns></returns>
        public DataTable ChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select top 5 * from chartdata", con);
            // Creating Chart
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
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
