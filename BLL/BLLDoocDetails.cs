using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;

namespace BLL
{
    public class BLLDoocDetails
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
            try
            {
                DALDocDetail obj = new DALDocDetail();
                List<string> li = obj.DocCategorie();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This Function Shows The Doctorsdetails in Grid view
        /// </summary>
        /// <returns>returns a Data Table</returns>
        public DataTable Doctordetais()
        {
            try
            {
                DALDocDetail obj = new DALDocDetail();
                obj.Categorie = _categorie;
                obj.Time = _time;
                DataTable dt = obj.DoctorDetails();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
