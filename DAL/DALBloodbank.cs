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
    public class DALBloodbank
    {
        public DataTable BloodDetails()
        {
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
                con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("GetBloodDetail", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                dt.Columns.Add("blodgroup");
                dt.Columns.Add("quantity");

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                //while (rdr.Read())
                //{
                //    DataRow dr = dt.NewRow();
                //    dr["blodgroup"] = rdr["BloodGroup"];
                //    dr["quantity"] = rdr["Quantity"];
                //    dt.Rows.Add(dr);


                //}
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
