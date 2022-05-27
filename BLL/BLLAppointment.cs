using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLAppointment
    {
        string _doccategorie;
        DateTime _time;
        string _docname;
        public string Doccategorie { get => _doccategorie; set => _doccategorie = value; }
        public DateTime Time { get => _time; set => _time = value; }
        public string Docname { get => _docname; set => _docname = value; }

        /// <summary>
        /// This Function returns doctors name from BLL
        /// </summary>
        /// <returns>List of avilable doctors</returns>
        public List<string> DocSecVal()
        {
            try
            {
                DALAppointment dal = new DALAppointment();
                dal.DocCategorie = _doccategorie;
                dal.Time = _time;
                List<string> DocSec  =dal.DropDocValueUpdate();
                return DocSec;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// It returns a data table populated with emergency patient
        /// </summary>
        /// <returns>Data set containing emergency patient details</returns>
        public DataSet GetemergancyData()
        {
            try
            {
                DALAppointment obj = new DALAppointment();
                DataSet ds= obj.EmergencyPatient();
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Fetch patient appoinment data with assiociated doctor
        /// </summary>
        /// <returns>Data Table containing patient details</returns>
        public DataTable Getregularpatient()
        {
            try
            {
                DALAppointment obj = new DALAppointment();
                obj.Docname = _docname;
                obj.Time = _time;
                DataTable dt =obj.DataGridAppionments();
                return dt;// Have to check if the data table has table or not 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This Function Returns problem list
        /// </summary>
        /// <returns>List of problem</returns>
        public List<string> GetProblem()
        {
            try
            {
                DALAppointment obj = new DALAppointment();
                List<string> Problem = obj.Getproblems();
                return Problem;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
