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
    public class QTagsUpdate_EPC
    {
        private frmAppForm m_AppForm;

        public QTagsUpdate_EPC(frmAppForm appForm)
        {
            m_AppForm = appForm;
        }

        public string add(ref DataSet ds, ref DataSet dsPOEPC, string epc, string sku, string upc, string description, string boxid, int status, string location, string vendorid)
        {
            try
            {
                QTagsUpdate _QTagsUpdate = new QTagsUpdate(m_AppForm);
                if (_QTagsUpdate.check_product_epc(ref dsPOEPC, epc) == true)
                {
                    DataRow dr = ds.Tables[0].NewRow();
                    dr["EPC"] = epc;
                    dr["ProductSku"] = sku;
                    dr["Upc"] = upc;
                    dr["Description"] = description;
                    dr["ContainerId"] = boxid.ToString();
                    dr["Status"] = status;
                    dr["StoreNumber"] = vendorid;
                    ds.Tables[0].Rows.Add(dr);
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_EPC-add : " + ex.Message);
                return ex.Message;
            }
        }
        public string update(ref DataSet ds, string epc, string sku, string upc, string description, string boxid, string status, string location, string vendorid)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("StoreNumber = '" + epc + "'");
                if (drs.Length > 0)
                {
                    drs[0]["EPC"] = epc;
                    drs[0]["ProductSku"] = sku;
                    drs[0]["Upc"] = upc;
                    drs[0]["Description"] = description;
                    drs[0]["ContainerId"] = boxid;
                    drs[0]["Status"] = status;
                    drs[0]["StoreNumber"] = vendorid;
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_EPC-update : " + ex.Message);
                return ex.Message;
            }
        }

        public string updateRead(ref DataSet ds, string epc)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("EPC = '" + epc + "'");
                if (drs.Length > 0)
                {
                    drs[0]["QtyRead"] = 1;
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_EPC-updateRead : " + ex.Message);
                return ex.Message;
            }
        }

    }

    public class QTagsUpdate
    {
        private frmAppForm m_AppForm;

        public QTagsUpdate(frmAppForm appForm)
        {
            m_AppForm = appForm;
        }
        public string add_box(ref System.Windows.Forms.Form m_form, ref DataSet ds, string OrderNumber, string StoreNumber, string ContainerId)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("OrderNumber='" + OrderNumber + "' and " +
                                                    "StoreNumber='" + StoreNumber + "' and " +
                                                    "ContainerId='" + ContainerId + "'");

                if (drs.Length > 0)
                {
                    drs[0]["QtyRead"] = int.Parse(drs[0]["QtyRead"].ToString()) + 1;

                    int QtyRead = (int)drs[0]["QtyRead"];
                    int DigitalQuantity = (int)drs[0]["DigitalQuantity"];


                    //if ((DigitalQuantity == QtyRead) && (QtyRead > 0) && (ContainerId != ""))
                    //{
                    //    // save cid
                    //   //((frmAppForm)m_form).save_cid(ContainerId, ((frmAppForm)m_form).get_tags(ContainerId));

                    //    //QTags.accept_box(OrderNumber, ContainerId);

                    //}
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_-add_box : " + ex.Message);
                return ex.Message;
            }
        }


        public string add_product(ref DataSet ds, string OrderNumber, string StoreNumber, string ContainerId
                                            , string ProductSku)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("OrderNumber='" + OrderNumber + "' and " +
                                                    "StoreNumber='" + StoreNumber + "' and " +
                                                    "ContainerId='" + ContainerId + "' and " +
                                                    "ProductSku='" + ProductSku + "'");

                if (drs.Length > 0)
                {
                    drs[0]["QtyRead"] = int.Parse(drs[0]["QtyRead"].ToString()) + 1;
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_-add_product : " + ex.Message);
                return ex.Message;
            }
        }

        public bool check_product_epc(ref DataSet ds, string EPC)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("EPC='" + EPC + "'");

                if (drs.Length > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_-check_product_epc : " + ex.Message);
                return false;
            }
        }

        public string add_po(ref DataSet ds, string OrderNumber)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("OrderNumber='" + OrderNumber + "'");

                if (drs.Length > 0)
                {
                    drs[0]["QtyRead"] = int.Parse(drs[0]["QtyRead"].ToString()) + 1;

                    int QtyRead = (int)drs[0]["QtyRead"];
                    int DigitalQuantity = (int)drs[0]["DigitalQuantity"];

                    if ((DigitalQuantity == QtyRead) && (QtyRead > 0))
                    {
                        // update time
                        drs[0]["stop_time"] = DateTime.Now;

                        update_time_dc_po_receive(OrderNumber);
                    }
                }
                return "";
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_-add_po : " + ex.Message);
                return ex.Message;
            }
        }

        public string update_time_dc_po_receive(string ordernumber)
        {
            DBManager dbmgr = new DBManager();
            string sql = "";
            string strType = "";
            ArrayList data = new ArrayList();
            try
            {
                data.Clear(); strType = "";
                data.Add(ordernumber); strType += "T";

                sql = "exec sp_DC_PO_Update_FinishTime @p1";
                dbmgr.ExecuteCommand(sql, strType, data);
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTagsUpdate_-update_time_dc_po_receive : " + ex.Message);
                return ex.Message;
            }
            return "";
        }

    }

    public class QTSumary
    {
        private frmAppForm m_AppForm;

        public QTSumary(frmAppForm appForm)
        {
            m_AppForm = appForm;
        }

        public string SumBox(ref DataSet ds)
        {
            try
            {
                DataRow[] drs = ds.Tables[0].Select("QtyRead > 0");
                if (drs.Length > 0)
                {
                    return drs.Length.ToString() + "/" + ds.Tables[0].Rows.Count.ToString();
                }
                else
                {
                    return drs.Length.ToString() + "/" + ds.Tables[0].Rows.Count.ToString();
                }
            }
            catch(Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTSumary_-SumBox : " + ex.Message);
                return "0/0";
            }
        }
        public string SumSKU(ref DataSet ds)
        {
            try
            {
                int qty = 0;
                int read = 0;

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    read += (int)ds.Tables[0].Rows[i]["QtyRead"];
                    qty += (int)ds.Tables[0].Rows[i]["DigitalQuantity"];
                }
                return read.ToString() + "/" + qty.ToString();
            }
            catch (Exception ex)
            {
                cFileIO.WriteLogToFile(m_AppForm.deviceip.Replace(".", "") + "-DB", "QTSumary_-SumSKU : " + ex.Message);
                return "0/0";
            }
        }
    }
}
