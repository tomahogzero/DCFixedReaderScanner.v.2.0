using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Configuration;
using System.Threading;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DCRFIDReader
{
    public class DBManager
    {
        private bool enc = false;
        private SqlConnection conn = null;


        public string getConnString()
        {
            // Dim strConnString As String = "" ConfigurationManager.ConnectionStrings(strConfName).ConnectionString
            string strConnString = aconfig.getconnecctionstring();
            return strConnString.Trim();
        }

        public string getConnString(string ServerName, string DatabaseName, string UserName, string Password)
        {
            // Dim strConnString As String = "" ConfigurationManager.ConnectionStrings(strConfName).ConnectionString
            string strConnString = "Data Source=" + ServerName.Trim() + ";" + "Initial Catalog=" + DatabaseName.Trim() + ";" + "User ID=" + UserName.Trim() + ";" + "Password=" + Password.Trim() + ";";

            return strConnString.Trim();
        }

        public SqlConnection getDBConnection()
        {
            string strConnString = getConnString();
            return new System.Data.SqlClient.SqlConnection(strConnString);
        }

        public SqlConnection getDBConnection(string ServerName, string DatabaseName, string UserName, string Password)
        {
            string strConnString = getConnString(ServerName.Trim(), DatabaseName.Trim(), UserName.Trim(), Password.Trim());
            return new SqlConnection(strConnString);
        }

        public void OpenConnection(ref SqlConnection Conn, bool Open)
        {
            if (Open == true)
            {
                if (Conn.State != ConnectionState.Open)
                    Conn.Close();
                Conn = getDBConnection();
                Conn.Open();
            }
            else
                Conn.Close();
        }


        public void CreateParam(ref SqlCommand Cmd, string StrType)
        {
            // T:Text, M:Memo, Y:Currency, D:Datetime, I:Integer, S:Single, B:Boolean, P: Picture
            int i;
            string j;
            for (i = 1; i <= StrType.Length; i++)
            {
                j = StrType.Substring(i-1, 1).ToUpper();
                SqlParameter P1 = new SqlParameter();
                P1.ParameterName = "@P" + i;
                switch (j)
                {
                    case "T":
                        {
                            P1.SqlDbType = SqlDbType.VarChar;
                            break;
                        }

                    case "M":
                        {
                            P1.SqlDbType = SqlDbType.Text;
                            break;
                        }

                    case "Y":
                        {
                            P1.SqlDbType = SqlDbType.Money;
                            break;
                        }

                    case "D":
                        {
                            P1.SqlDbType = SqlDbType.DateTime;
                            break;
                        }

                    case "I":
                        {
                            P1.SqlDbType = SqlDbType.Int;
                            break;
                        }

                    case "S":
                        {
                            P1.SqlDbType = SqlDbType.Decimal;
                            break;
                        }

                    case "B":
                        {
                            P1.SqlDbType = SqlDbType.Bit;
                            break;
                        }

                    case "P":
                        {
                            P1.SqlDbType = SqlDbType.Image;
                            break;
                        }

                    case "U":
                        {
                            P1.SqlDbType = SqlDbType.UniqueIdentifier;
                            break;
                        }
                }
                Cmd.Parameters.Add(P1);
            }
        }

        public void ExecuteCommand(ref SqlConnection Cn, ref SqlCommand Cmd, string strSQL, string strType, ArrayList data)
        {
            Cmd.Connection = Cn;
            Cmd.CommandText = strSQL;
            Cmd.Parameters.Clear();
            CreateParam(ref Cmd, strType);
            for (int i = 0; i <= data.Count - 1; i++)
                Cmd.Parameters[i].Value = data[i];
            Cmd.ExecuteNonQuery();
        }
        public void ExecuteCommand(string strSQL, string strType, ArrayList data)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            OpenConnection(ref cn, true);
            Cmd.Connection = cn;
            Cmd.CommandText = strSQL;
            Cmd.Parameters.Clear();
            CreateParam(ref Cmd, strType);
            for (int i = 0; i <= data.Count - 1; i++)
                Cmd.Parameters[i].Value = data[i];
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        public void ExecuteCommand(ref SqlConnection Cn, ref SqlCommand Cmd, string strSQL)
        {
            Cmd.Connection = Cn;
            Cmd.CommandText = strSQL;
            Cmd.ExecuteNonQuery();
        }

        public void ExecuteCommand(string strSQL)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            OpenConnection(ref cn, true);
            Cmd.Connection = cn;
            Cmd.CommandText = strSQL;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }
        public DataSet ExecuteCommand_Select_Ds(string strSQL)
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            OpenConnection(ref cn, true);
            Cmd.Connection = cn;
            Cmd.CommandTimeout = 10;
            Cmd.CommandText = strSQL;
            da.SelectCommand = Cmd;
            da.Fill(ds, "data");
            cn.Close();
            return ds;
        }

        public DataSet ExecuteCommand_Select_Ds(string strSQL, string strType, ArrayList data)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlConnection cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            OpenConnection(ref cn, true);
            Cmd.Connection = cn;
            Cmd.CommandText = strSQL;
            Cmd.Parameters.Clear();
            CreateParam(ref Cmd, strType);
            for (int i = 0; i <= data.Count - 1; i++)
                Cmd.Parameters[i].Value = data[i];
            da.SelectCommand = Cmd;
            da.Fill(ds, "data");
            cn.Close();
            return ds;
        }

        public DataTable GetDataTable(ref SqlCommand Cmd, string TableName = "Table")
        {
            SqlDataAdapter DA = new SqlDataAdapter();
            DataTable DT = new DataTable(TableName);
            DataSet Ds = new DataSet();
            try
            {
                DA.SelectCommand = Cmd;
                DA.Fill(Ds);
                DT = Ds.Tables[0];
            }
            catch (Exception x1)
            {
               // Information.Err.Raise(60002, Description: x1.Message);                
            }
            return DT;
        }



        public bool TestConnection(string server, string databasename, string uid, string pwd)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = getConnString(server, databasename, uid, pwd);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private object ConfigurationManager()
        {
            throw new NotImplementedException();
        }
    }
}
