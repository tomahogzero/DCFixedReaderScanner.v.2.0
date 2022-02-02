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
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace DCRFIDReader
{
    public class db
    {
        public void CreateParam(ref SqlCommand Cmd, string StrType)
        {
            // T:Text, M:Memo, Y:Currency, D:Datetime, I:Integer, S:Single, B:Boolean, P: Picture
            int i;
            string j;
            for (i = 1; i <= StrType.Length; i++)
            {
                j = StrType.Substring(i, 1).ToUpper();
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
        public void ExecuteCommand(ref SqlCommand Cmd, string strSQL, string strType, ArrayList data)
        {
            SqlConnection cn = new SqlConnection();
            OpenDatabase(ref cn, true);

            Cmd.Connection = cn;
            Cmd.CommandText = strSQL;
            Cmd.Parameters.Clear();
            CreateParam(ref Cmd, strType);
            for (int i = 0; i <= data.Count - 1; i++)
                Cmd.Parameters[i].Value = data[i];
            Cmd.ExecuteNonQuery();
        }
        public DataSet ExecuteCommand_DataSet(ref SqlCommand Cmd, string strSQL, string strType, ArrayList data)
        {
            SqlConnection cn = new SqlConnection();
            OpenDatabase(ref cn, true);

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            Cmd.Connection = cn;
            Cmd.CommandText = strSQL;
            Cmd.Parameters.Clear();
            CreateParam(ref Cmd, strType);
            for (int i = 0; i <= data.Count - 1; i++)
            {
                Cmd.Parameters[i].Value = data[i];
            }
            da.SelectCommand = Cmd;
            da.Fill(ds, "data");
            return ds;
        }

        public void ExecuteCommand(ref SqlConnection Cn, ref SqlCommand Cmd, string strSQL)
        {
            Cmd.Connection = Cn;
            Cmd.CommandText = strSQL;
            Cmd.ExecuteNonQuery();
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
                //Information.Err.Raise(60002, Description: x1.Message);     
                return DT;          
            }
            return DT;
        }

        public void OpenDatabase(ref SqlConnection Conn, bool Open)
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

        public SqlConnection getDBConnection()
        {
            string strConnString = aconfig.getconnecctionstring();
            return new System.Data.SqlClient.SqlConnection(strConnString);
        }
    }
}

