using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLLogin
    {
        string _username;
        string _password;
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public int Login()
        {
            try
            {
                DALLogin log = new DALLogin();
                log.Username = _username;
                log.Password = _password;
                int check = log.Login();
                return check;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
