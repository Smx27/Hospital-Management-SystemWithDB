using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLBloodBank
    {
        public DataTable BloodDetails()
        {
            try
            {
                DALBloodbank obj = new DALBloodbank();
                DataTable dt= obj.BloodDetails();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
