using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace BLL
{
    public class BLLSettings
    {
        string _categorie;
        string _oldpass;
        string _newpass;
        string _docname;
        DateTime _time;
        public string Categorie { get => _categorie; set => _categorie = value; }
        public string Oldpass { get => _oldpass; set => _oldpass = value; }
        public string Newpass { get => _newpass; set => _newpass = value; }
        public string Docname { get => _docname; set => _docname = value; }
        public DateTime Time { get => _time; set => _time = value; }


        /// <summary>
        /// This function shows which doctors are absent
        /// </summary>
        /// <returns>return a Binding data source</returns>
        public BindingSource GetAbsentDoc()
        {
            try
            {
                DALSettings settings = new DALSettings();
                BindingSource src= settings.GetAbsentDoc();
                return src;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Get Categorie data from DB
        /// </summary>
        /// <returns>Listt of string</returns>
        public List<string> GetCategorieData()
        {
            try
            {
                DALSettings settings = new DALSettings();
                List<string> li = settings.GetCategorieData();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Gives data to Doctor name on repect to categorie
        /// </summary>
        /// <returns>List of doc name</returns>
        public List<string> GetDocDetails()
        {
            try
            {
                DALSettings settings = new DALSettings();
                settings.Categorie = _categorie;
                List<string> li = settings.GetDocDetails();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function Update password 
        /// </summary>
        /// <returns>a flag if the passchaanged or not</returns>
        public int UpdatePassword()
        {
            try
            {
                DALSettings settings = new DALSettings();
                settings.Oldpass = _oldpass;
                settings.Newpass = _newpass;
                int flaag = settings.UpdatePassword();
                return flaag;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public string switchvalue()
        {
            try
            {
                DALSettings settings = new DALSettings();
                settings.Categorie = _categorie;
                settings.Docname = _docname;
                string value = settings.switchValue();
                return value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int UpdateChartData()
        {
            try
            {
                DALSettings settings = new DALSettings();
                settings.Time = Time;
                int change = settings.UpdateChartData();
                return change;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
