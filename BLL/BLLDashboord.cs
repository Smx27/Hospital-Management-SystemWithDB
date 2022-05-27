using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BLLDashboord
    {
        /// <summary>
        /// Thhis functions Gives Value to progressbar
        /// </summary>
        /// <returns>It returns </returns>
        public int ProgressBarData()
        {
            try
            {
                DALDashbord obj = new DALDashbord();
                int data=obj.ProgressbarData();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// This function returns Avilable bed data
        /// </summary>
        /// <returns>Return a percentage of avilable bed</returns>
        public int AvilableDocPercentage()
        {
            try
            {
                DALDashbord obj = new DALDashbord();
                int Data=obj.AvilableBedPercentage();
                return Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Give Data To Charte
        /// </summary>
        /// <returns>Data Table</returns>
        public DataTable ChartData()
        {
            try
            {
                DALDashbord obj = new DALDashbord();
                DataTable dt = obj.ChartData();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
