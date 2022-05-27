using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using System.Windows.Forms;

namespace BLL
{
    public class BLLEmergency
    {
        DateTime _date;
        string _name;
        string _bedno;
        string _pname;
        string _sextype;
        string _bloodgrp;
        string _cause;
        string _admittedby;
        string _contactno;
        string _doctorname;

        public DateTime Date { get => _date; set => _date = value; }
        public string Name { get => _name; set => _name = value; }
        public string Bedno { get => _bedno; set => _bedno = value; }
        public string Pname { get => _pname; set => _pname = value; }
        public string Sextype { get => _sextype; set => _sextype = value; }
        public string Bloodgrp { get => _bloodgrp; set => _bloodgrp = value; }
        public string Cause { get => _cause; set => _cause = value; }
        public string Admittedby { get => _admittedby; set => _admittedby = value; }
        public string Contactno { get => _contactno; set => _contactno = value; }
        public string Doctorname { get => _doctorname; set => _doctorname = value; }

        /// <summary>
        /// This function Save all entered data into db 
        /// </summary>
        /// <returns>A Flag if insertion is successfully or not</returns>
        public int InsertData()
        {
            try
            {
                DALEmergency obj = new DALEmergency();
                obj.Admittedby = _admittedby;
                obj.Bedno = _bedno;
                obj.Bloodgrp = _bloodgrp;
                obj.Cause = _cause;
                obj.Contactno = _contactno;
                obj.Date = _date;
                obj.Doctorname = _doctorname;
                obj.Pname = _pname;
                obj.Sextype = _sextype;
                int effectedrow=obj.InsertData();
                return effectedrow;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function discharge Patients who admitted in emergency ward
        /// </summary>
        /// <returns>Return a flag if discharge complete or not</returns>
        public int Discharge()
        {
            try
            {
                DALEmergency emr = new DALEmergency();
                emr.Date = _date;
                emr.Name = _name;
                int change=emr.Discharge();
                return change;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This Returns The patient name who dont get discharge from hospital
        /// </summary>
        /// <returns>Return a collection of names</returns>
        public AutoCompleteStringCollection SearchPatientName()
        {
            try
            {
                DALEmergency emr = new DALEmergency();
                AutoCompleteStringCollection col= emr.SearchPatientName();
                return col;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function book bed on the pation name
        /// </summary>
        /// <returns>Return A flag if booking successfully or not</returns>
        public int AquairBed()
        {
            try
            {
                DALEmergency emergency = new DALEmergency();
                emergency.Bedno = _bedno;
                int changes = emergency.AquairBed();
                return changes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function add data to Doctor Drop Down
        /// </summary>
        /// <returns>Returns a list of doctors name</returns>
        public List<string> AddDropDocVal()
        {
            try
            {
                DALEmergency emergency = new DALEmergency();
                List<string> li=emergency.AddDropDocVal();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function add data to Avilable bed Drop Down
        /// </summary>
        /// <returns>Returns a list of avilable bed number</returns>
        public List<string> AddDropAvilabelBedData()
        {
            try
            {
                DALEmergency emr = new DALEmergency();
                List<string> li = emr.AddDropAvilabelBedData();
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
