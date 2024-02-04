using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DCRFIDReader
{
    public class QTags
    {
        private frmAppForm m_AppForm;

        public QTags(frmAppForm appForm)
        {
            m_AppForm = appForm;
        }

        public DataSet get_company()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbr_dbserver + ";Initial Catalog=" + dbValues.dbr_dbname + ";User ID=" + dbValues.dbr_uid + ";Password=" + dbValues.dbr_pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select c.CompanyId,c.CompanyId + ' : ' + c.CompanyName as CompanyName from Company c where CompanyType = 1";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_company | " + ex.Message);
                conn.Close();
                return null;
            }
        }

        public string get_companyid(string username)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbr_dbserver + ";Initial Catalog=" + dbValues.dbr_dbname + ";User ID=" + dbValues.dbr_uid + ";Password=" + dbValues.dbr_pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select c.CompanyId,c.CompanyName" +
                            " from Company c" +
                                " inner" +
                            " join [User] u" +
                            " on c.id = u.CompanyId" +
                            " where u.UserName = '" + username + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    return "";
                }
                else
                {
                    return ds.Tables[0].Rows[0]["CompanyId"].ToString();
                }

            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_companyid | " + ex.Message);
                conn.Close();
                return "";
            }
        }

        public DataSet get_booking(string vendorid)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbr_dbserver + ";Initial Catalog=" + dbValues.dbr_dbname + ";User ID=" + dbValues.dbr_uid + ";Password=" + dbValues.dbr_pwd;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "exec sp_Booking_Receive '" + vendorid + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_booking | " + ex.Message);
                conn.Close();
                return null;
            }
        }


        public async Task<bool> save_epc_scan(string epc, string gatenumber)
        {

            DBManager dbMgr = new DBManager();
            try
            {

                DataSet ds;
                string strType = "";
                ArrayList data = new ArrayList();

                data.Clear(); strType = "";
                data.Add(epc); strType += "T";
                data.Add(gatenumber); strType += "T";

                string sql = "exec sp_dc_save_epc_scan @p1,@p2";

                ds = dbMgr.ExecuteCommand_Select_Ds(sql, strType, data);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if ((int)ds.Tables[0].Rows[0]["row_count"] > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "save_epc_scan | " + ex.Message);
                return false;
            }
        }

        public async Task<DataSet> get_box(string deviceid)
        {
            DBManager dbMgr = new DBManager();
            try
            {

                DataSet ds;
                string strType = "";
                ArrayList data = new ArrayList();

                data.Clear(); strType = "";
                data.Add(deviceid); strType += "T";

                string sql = "exec sp_DC_PO_Receive_byBOX @p1";

                ds = dbMgr.ExecuteCommand_Select_Ds(sql, strType, data);
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_box | " + ex.Message);
                return null;
            }
        }

        public async Task<DataSet> get_product(string deviceid)
        {
            DBManager dbMgr = new DBManager();
            try
            {
                DataSet ds;
                string strType = "";
                ArrayList data = new ArrayList();

                data.Clear(); strType = "";
                data.Add(deviceid); strType += "T";

                string sql = "exec sp_DC_PO_Receive_byUPC @p1";

                ds = dbMgr.ExecuteCommand_Select_Ds(sql, strType, data);
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_product | " + ex.Message);
                return null;
            }
        }

        public async Task<DataSet> get_product_epc(string deviceid)
        {
            DBManager dbMgr = new DBManager();
            try
            {

                DataSet ds;
                string strType = "";
                ArrayList data = new ArrayList();

                data.Clear(); strType = "";
                data.Add(deviceid); strType += "T";

                string sql = "exec sp_DC_PO_Receive_byEPC @p1";

                ds = dbMgr.ExecuteCommand_Select_Ds(sql, strType, data);
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_product_epc | " + ex.Message);
                return null;
            }
        }

        public async Task<DataSet> get_po(string deviceid)
        {
            DBManager dbMgr = new DBManager();
            try
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds;
                string strType = "";
                ArrayList data = new ArrayList();

                data.Clear(); strType = "";
                data.Add(deviceid); strType += "T";

                string sql = "exec sp_DC_PO_Receive @p1";

                ds = dbMgr.ExecuteCommand_Select_Ds(sql, strType, data);
                return ds;
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "get_po | " + ex.Message);
                return null;
            }
        }

        public async Task<DataRow> GetEPCDetail(string GateNumber, DataTable dtTag, string deviceid, int antenna, string epc)
        {
            //string GateNumber = DeviceGate.GetGateNumber(_dtDeviceGate, deviceid, antenna);

            if (GateNumber == "") return null;

            try
            {
                DataRow[] dr = dtTag.Select("EPC = '" + epc + "' and QtyRead = 0");
                if (dr.Length > 0)
                {
                    return dr[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "GetEPCDetail | " + ex.Message);
                return null;
            }
        }

        public string accept_po(string gate,
                                string res_person,
                                string order_number,
                                string time_st,
                                string time_sp,
                                string time_count)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbl_dbserver + ";Initial Catalog=" + dbValues.dbl_dbname + ";User ID=" + dbValues.dbl_uid + ";Password=" + dbValues.dbl_pwd;
                conn.Open();

                SqlCommand dcmd = new SqlCommand();
                string sql = "EXEC	[dbo].[sp_dc_receive_po_save]" +
                                " @gate = N'" + gate + "'," +
                                " @res_person = N'" + res_person + "'," +
                                " @ordernumber = N'" + order_number + "'," +
                                " @time_st = N'" + time_st + "'," +
                                " @time_sp = N'" + time_st + "'," +
                                " @time_count = N'" + time_count + "'";
                dcmd.Connection = conn;
                dcmd.CommandText = sql;
                dcmd.ExecuteNonQuery();

                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "accept_po | " + ex.Message);
                conn.Close();
                return ex.Message;
            }
        }

        public string accept_box(string order_number, string ContainerId)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=" + dbValues.dbl_dbserver + ";Initial Catalog=" + dbValues.dbl_dbname + ";User ID=" + dbValues.dbl_uid + ";Password=" + dbValues.dbl_pwd;
                conn.Open();

                SqlCommand dcmd = new SqlCommand();
                string sql = "EXEC	[dbo].[sp_dc_receive_box_save]" +
                                    " @OrderNumber = N'" + order_number + "'," +
                                    " @ContainerId = N'" + ContainerId + "'";
                dcmd.Connection = conn;
                dcmd.CommandText = sql;
                dcmd.ExecuteNonQuery();

                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "accept_box | " + ex.Message);
                conn.Close();
                return ex.Message;
            }
        }
    }
}
