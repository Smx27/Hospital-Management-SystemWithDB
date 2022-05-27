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
    public class DALEmergency
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
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("EmergencyDataInsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eName", _pname); //@Ename,@ESex,@EBloodGroup,@ECause,@EAdmittedBy,@EContact,@EAvilableDoctors,@EAVilableBed
            cmd.Parameters.AddWithValue("@Esex", _sextype);
            cmd.Parameters.AddWithValue("@EBloodGroup", _bloodgrp);
            cmd.Parameters.AddWithValue("@ECause", _cause);
            cmd.Parameters.AddWithValue("@EAdmittedBy", _admittedby);
            cmd.Parameters.AddWithValue("@EContact", _contactno);
            cmd.Parameters.AddWithValue("@EAvilableDoctors", _doctorname);
            cmd.Parameters.AddWithValue("@EAVilableBed", _bedno);
            cmd.Parameters.AddWithValue("@EDate", _date);
            cmd.Parameters.AddWithValue("@Discharge", 0);
            try
            {
                con.Open();
                int Row = cmd.ExecuteNonQuery();
                return Row;

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
        /// This function discharge Patients who admitted in emergency ward
        /// </summary>
        /// <returns>Return a flag if discharge complete or not</returns>
        public int Discharge()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("EmergencyDischarge", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DischargeDate", _date);
            cmd.Parameters.AddWithValue("@Name", _name);
            try
            {
                con.Open();
                int change = cmd.ExecuteNonQuery();
                return change;
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
        /// This Returns The patient name who dont get discharge from hospital
        /// </summary>
        /// <returns>Return a collection of names</returns>
        public AutoCompleteStringCollection SearchPatientName()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("PatientToBeDischarged", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        col.Add(rdr[0].ToString());
                    }
                }
                rdr.Close();
                return col;
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
        /// This function book bed on the pation name
        /// </summary>
        /// <returns>Return A flag if booking successfully or not</returns>
        public int AquairBed()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("AquairBed", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BedNo", _bedno);
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
        /// <summary>
        /// This function add data to Doctor Drop Down
        /// </summary>
        /// <returns>Returns a list of doctors name</returns>
        public List<string> AddDropDocVal()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("EmerGetDocDetails", connection);
            command.CommandType = CommandType.StoredProcedure;
            List<string> li = new List<string>();
            try
            {
                connection.Open();
                SqlDataReader rdr = command.ExecuteReader();
                while (rdr.Read())
                {
                    li.Add(rdr["Name"].ToString());
                }
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        /// <summary>
        /// This function add data to Avilable bed Drop Down
        /// </summary>
        /// <returns>Returns a list of avilable bed number</returns>
        public List<string> AddDropAvilabelBedData()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command1 = new SqlCommand("EmerBedDetails", connection);
            command1.CommandType = CommandType.StoredProcedure;
            List<string> li = new List<string>();
            try
            {
                connection.Open();
                SqlDataReader rdr = command1.ExecuteReader();
                while (rdr.Read())
                {
                    li.Add(rdr["BedNum"].ToString());
                }
                return li;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
