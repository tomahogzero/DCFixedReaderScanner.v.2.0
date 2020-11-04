using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CS_RFID3_Host_Sample1
{
    public class QTags
    {
        public static DataSet get_company()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select c.CompanyId,c.CompanyName from Company c where CompanyType = 1";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static DataSet get_booking(string vendorid)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_Booking_Receive '" + vendorid + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }


        public static DataSet get_epc(string epc)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_search_epc" +
                                " @epc = '" + epc.Trim() + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;                
            }
            catch 
            {
                conn.Close();
                return null;
            }
        }

        public static DataSet get_box(string vendorid,string bookingno)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_PO_Receive_byBOX '" + vendorid + "','" + bookingno + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static DataSet get_product(string vendorid,string bookingno)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_PO_Receive_byUPC '" + vendorid + "','" + bookingno + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }

        public static DataSet get_po(string vendorid,string bookingno)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbserver + ";Initial Catalog=" + dbValues.dbname + ";User ID=" + dbValues.uid + ";Password=" + dbValues.pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_PO_Receive '" + vendorid + "','" + bookingno + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch
            {
                conn.Close();
                return null;
            }
        }
    }
}
