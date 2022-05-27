using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DAL
{
    public class DALLogin
    {
        string _username;
        string _password;
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        /// <summary>
        /// This function Rtrive login data from DB
        /// </summary>
        /// <returns> A Flag If Login Success Or not </returns>
        public int Login()
        {
            string CS = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            SqlConnection con = new SqlConnection(CS);
            SqlCommand command = new SqlCommand("LoginData", con);//Passing A prcedure 
            command.CommandType = CommandType.StoredProcedure;// Defing the coommand is a tored procedure
            //command.Parameters.AddWithValue("@Username", txtUsername.Text);//creating a user name parameter of to pass a value
            //command.Parameters.AddWithValue("@Password",txtPassword.Text);//Creating a parameter for password to insert value in db
            con.Open();// opening database
            SqlDataReader rdr = command.ExecuteReader();// creating a execute data reader obj
            //BindingSource source = new BindingSource();//creating a binding source in 
            //source.DataSource = rdr; // fro giving resource to a dat agrid
            //dataGridView1.DataSource = source; // initilizing data to datagrid
            try
            {
                while (rdr.Read())
                {
                    if (_username == rdr["Username"].ToString() && _password == rdr["Password"].ToString())
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                return 2;
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
