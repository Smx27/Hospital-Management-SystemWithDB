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
    public class BLLAddPatient
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
        /// This function returns data contains Doctor name 
        /// </summary>
        /// <returns>Returns list of doctors name</returns>
        public List<string> getdocname()
        {
            try
            {
                DALAddPatient obj = new DALAddPatient();
                obj.Categorie = _categorie;
                List<string> li= obj.GetDoctorname();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        /// <summary>
        /// Insert Data into database
        /// </summary>
        /// <returns>it returns a flag if database if effected</returns>
        public int InsertData()
        {
            try
            {
                DALAddPatient obj = new DALAddPatient();
                obj.Patientname = _patientname;
                obj.Categorie = _categorie;
                obj.Time = _time;
                obj.Address = _address;
                obj.Contact = _contact;
                obj.Problem = _problem;
                obj.Doctor = _doctor;
                obj.Payment = _payment;
                int effectedrows=obj.Insertpatientdata();
                return effectedrows;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// this function returns a doctor name on selected categorie
        /// </summary>
        /// <returns>It returns a list of doctor name on selected categorie</returns>
        public List<string> Getproblems()
        {
            try
            {
                DALAppointment obj = new DALAppointment();
                List<string> li= obj.Getproblems();
                return li;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /// <summary>
        /// This function get doctor name on respect to categorie
        /// </summary>
        /// <returns>Return List Of Doctor On selected Categorie</returns>
        public List<string> GetDocName()
        {
            try
            {
                DALAddPatient obj = new DALAddPatient();
                obj.Categorie = _categorie;
                obj.Time = _time;
                List<string> li= obj.GetDocName();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
