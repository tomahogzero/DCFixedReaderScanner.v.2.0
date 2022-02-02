using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DCRFIDReader
{
    public class SyncData
    {
        #region "Get Data From Clud"

        public static DataSet GetDt_UserRole_Remote(string username, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * from [UserRole] where id in (select UserRoleId from [User] where UserName = '" + username + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_User_Remote(string username,ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * from [User] where UserName = '" + username + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }


        public static DataSet GetDt_UserRoleByCompanyId_Remote(string companyid, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * from [UserRole] where id in (select UserRoleId from [user]" +
                            " where CompanyId = '" + companyid + "')"; // in (select Id from Company where CompanyId = '" + companyid + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_UserByCompanyId_Remote(string companyid, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * from [user]" +
                            " where CompanyId = '" + companyid + "'"; // in (select Id from Company where CompanyId = '" + companyid + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_Company_Remote(string username, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select c.*" +
                            " from Company c" +
                                    " inner" +
                                " join [User] u" +
                                " on c.CompanyId = u.CompanyId" +
                            " where u.UserName = '" + username + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_CompanyByCompanyId_Remote(string companyid, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select c.*" +
                            " from Company c" +
                            " where CompanyId = '" + companyid + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_POBooking_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from POBooking" +
                            " where BookingNo = '" + BookingNumber + "'";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_POPurchaseOrder_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from POPurchaseOrder" +
                            " where id in (select po.id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PCContainer_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PCContainer" +
                            " where id in (select c.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PCContainerItem_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PCContainerItem" +
                            " where id in (select citem.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRDivision_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRDivision" +
                            " where id in (select div.id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRSubClass sc" +
                                                        " on p.SubClassId = sc.Id" +
                                                    " left join PRClass class" +
                                                        " on sc.ClassId = class.id" +
                                                    " left join PRSection sec" +
                                                        " on class.SectionId = sec.id" +
                                                   " left join PRDepartment dep" +
                                                        " on sec.DepartmentId = dep.id" +
                                                    " left join PRDivision div" +
                                                        " on dep.DivisionId = div.id" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRDepartment_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRDepartment" +
                            " where id in (select dep.id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRSubClass sc" +
                                                        " on p.SubClassId = sc.Id" +
                                                    " left join PRClass class" +
                                                        " on sc.ClassId = class.id" +
                                                    " left join PRSection sec" +
                                                        " on class.SectionId = sec.id" +
                                                   " left join PRDepartment dep" +
                                                        " on sec.DepartmentId = dep.id" +
                                                    " left join PRDivision div" +
                                                        " on dep.DivisionId = div.id" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRSection_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRSection" +
                            " where id in (select sec.id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRSubClass sc" +
                                                        " on p.SubClassId = sc.Id" +
                                                    " left join PRClass class" +
                                                        " on sc.ClassId = class.id" +
                                                    " left join PRSection sec" +
                                                        " on class.SectionId = sec.id" +
                                                   " left join PRDepartment dep" +
                                                        " on sec.DepartmentId = dep.id" +
                                                    " left join PRDivision div" +
                                                        " on dep.DivisionId = div.id" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRProduct_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRProduct" +
                            " where id in (select p.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRSubClass_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRSubClass" +
                            " where id in (select sc.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRSubClass sc" +
                                                        " on p.SubClassId = sc.Id" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                conn.Close();
                return null;
            }
        }

        public static DataSet GetDt_PRClass_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRClass" +
                            " where id in (select sc.ClassId" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRSubClass sc" +
                                                        " on p.SubClassId = sc.Id" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch(Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_LOArea_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from LOArea" +
                            " where id in (select suba.AreaId" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                                                    " left join LOVendorLocation loc" +
                                                        " on pitem.VendorLocationId = loc.id " +
                                                    " left join LOSubArea suba" +
                                                        " on loc.SubAreaId = suba.id " +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_LOSubArea_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from LOSubArea" +
                            " where id in (select loc.SubAreaId" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                                                    " left join LOVendorLocation loc" +
                                                        " on pitem.VendorLocationId = loc.id " +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_LOVendorZone_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from LOVendorZone" +
                            " where id in (select loc.VendorZoneId" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                                                    " left join LOVendorLocation loc" +
                                                        " on pitem.VendorLocationId = loc.id " +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_LOVendorLocation_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from LOVendorLocation" +
                            " where id in (select pitem.VendorLocationId" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_PRProductItem_Remote(string VendorId, string BookingNumber, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbr_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRProductItem" +
                            " where id in (select pitem.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }

        public static DataSet GetDt_PRProductItem_Local(string VendorId, string BookingNumber,string cid, ref string err)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlDataAdapter da;
                DataSet ds = new DataSet();
                string sql = "select * " +
                            " from PRProductItem" +
                            " where id in (select pitem.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                                                    " left join PRProduct p" +
                                                        " on citem.ProductSku = p.Sku" +
                                                    " left join PRProductItem pitem" +
                                                        " on citem.id = pitem.ContainerItemId" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "'" +
                                        " and c.ContainerId = '" + cid + "')";

                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "data");

                conn.Close();
                err = "";
                return ds;
            }
            catch (Exception ex)
            {
                conn.Close();
                err = ex.Message;
                return null;
            }
        }
        #endregion

        #region "Clear Data"

        public static string POBooking_Clear_Local(string VendorId, string BookingNumber)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "delete " +
                            " from POBooking" +
                            " where BookingNo = '" + BookingNumber + "'";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }

        public static string POPurchaseOrder_Clear_Local(string VendorId, string BookingNumber)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "delete " +
                            " from POPurchaseOrder" +
                            " where id in (select po.id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                            " where po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();
                return ex.Message;
            }
        }

        public static string PCContainer_Clear_Local(string VendorId, string BookingNumber)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "delete " +
                            " from PCContainer" +
                            " where id in (select c.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PCContainerItem_Clear_Local(string VendorId, string BookingNumber)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "delete " +
                            " from PCContainerItem" +
                            " where id in (select citem.Id" +
                                            " from POPurchaseOrder po" +
                                                    " left join POBooking bk " +
                                                        " on po.BookingId = bk.id " +
                                                    " left join PCContainer c" +
                                                        " on po.OrderNumber = c.OrderNumber" +
                                                    " left join PCContainerItem citem" +
                                                        " on c.ContainerId = citem.ContainerId" +
                            " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string Clear_AllTable_Local()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "exec sp_clear_all";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRProductItem_Clear_Local(string VendorId, string BookingNumber)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();

                string sql = "delete " +
                            " from PRProductItem";

                            //" where id in (select pitem.Id" +
                            //                " from POPurchaseOrder po" +
                            //                        " left join PCContainer c" +
                            //                            " on po.OrderNumber = c.OrderNumber" +
                            //                        " left join PCContainerItem citem" +
                            //                            " on c.ContainerId = citem.ContainerId" +
                            //                        " left join PRProduct p" +
                            //                            " on citem.ProductSku = p.Sku" +
                            //                        " left join PRProductItem pitem" +
                            //                            " on citem.id = pitem.ContainerItemId" 
                            //" where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


                //sql = "delete " +
                //                 " from PRProductItem" +
                //                 " where ItemUniqueId in (select pitem.ItemUniqueId" +
                //                                 " from POPurchaseOrder po" +
                //                                         " left join PCContainer c" +
                //                                             " on po.OrderNumber = c.OrderNumber" +
                //                                         " left join PCContainerItem citem" +
                //                                             " on c.ContainerId = citem.ContainerId" +
                //                                         " left join PRProduct p" +
                //                                             " on citem.ProductSku = p.Sku" +
                //                                         " left join PRProductItem pitem" +
                //                                             " on citem.id = pitem.ContainerItemId" +
                //                 " where c.Status = 2 and po.VendorId = '" + VendorId + "'  and bk.BookingNo = '" + BookingNumber + "')";

                //cmd.Connection = conn;
                //cmd.CommandText = sql;
                //cmd.ExecuteNonQuery();

                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        #endregion

        #region "Save Data By Row"

        public static string UserRole_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_UserRole_Insert" +
                                            " @Id," +
                                            " @RoleName," +
                                            " @ModifiedAtUtc," +
                                            " @CreatedAtUtc," +
                                            " @CompanyType";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@RoleName", dr["RoleName"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@CompanyType", dr["CompanyType"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string User_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_User_Insert" +
                                " @Id" +
                                " , @ModifiedAtUtc" +
                                " , @CreatedAtUtc" +
                                " , @UserName" +
                                " , @FirstName" +
                                " , @LastName" +
                                " , @CompanyId" +
                                " , @UserRoleId";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@UserName", dr["UserName"]);
                cmd.Parameters.AddWithValue("@FirstName", dr["FirstName"]);
                cmd.Parameters.AddWithValue("@LastName", dr["LastName"]);
                cmd.Parameters.AddWithValue("@CompanyId", dr["CompanyId"]);
                cmd.Parameters.AddWithValue("@UserRoleId", dr["UserRoleId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string User_Company_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_Company_Insert " +
                            " @Id" +
                            " , @ModifiedAtUtc" +
                            " , @CreatedAtUtc" +
                            " , @CompanyName" +
                            " , @CompanyId" +
                            " , @CompanyType";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@CompanyName", dr["CompanyName"]);
                cmd.Parameters.AddWithValue("@CompanyId", dr["CompanyId"]);
                cmd.Parameters.AddWithValue("@CompanyType", dr["CompanyType"]);

                cmd.ExecuteNonQuery();

                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRProduct_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRProduct_Insert" +
                                        " @Id" +
                                        " , @ModifiedAtUtc" +
                                        " , @CreatedAtUtc" +
                                        " , @Upc" +
                                        " , @Sku" +
                                        " , @ItemNo" +
                                        " , @StyleNo" +
                                        " , @Description" +
                                        " , @Brand" +
                                        " , @PiecesPerCarton" +
                                        " , @UnitOfMeasure" +
                                        " , @ColorCode" +
                                        " , @SizeType" +
                                        " , @SubClassId";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@Upc", dr["Upc"]);
                cmd.Parameters.AddWithValue("@Sku", dr["Sku"]);
                cmd.Parameters.AddWithValue("@ItemNo", dr["ItemNo"]);
                cmd.Parameters.AddWithValue("@StyleNo", dr["StyleNo"]);
                cmd.Parameters.AddWithValue("@Description", dr["Description"]);
                cmd.Parameters.AddWithValue("@Brand", dr["Brand"]);
                cmd.Parameters.AddWithValue("@PiecesPerCarton", dr["PiecesPerCarton"]);
                cmd.Parameters.AddWithValue("@UnitOfMeasure", dr["UnitOfMeasure"]);
                cmd.Parameters.AddWithValue("@ColorCode", dr["ColorCode"]);
                cmd.Parameters.AddWithValue("@SizeType", dr["SizeType"]);
                cmd.Parameters.AddWithValue("@SubClassId", dr["SubClassId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRDivision_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRDivision_Insert" +
                                    " @Id" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc" +
                                    " , @DivisionName" +
                                    " , @DivisionCode" +
                                    " , @DivisionNumber";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@DivisionName", dr["DivisionName"]);
                cmd.Parameters.AddWithValue("@DivisionCode", dr["DivisionCode"]);
                cmd.Parameters.AddWithValue("@DivisionNumber", dr["DivisionNumber"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRDepartment_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRDepartment_Insert" +
                                    " @Id" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc" +
                                    " , @Name" +
                                    " , @Code" +
                                    " , @Number" +
                                    " , @DivisionId";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@Name", dr["Name"]);
                cmd.Parameters.AddWithValue("@Code", dr["Code"]);
                cmd.Parameters.AddWithValue("@Number", dr["Number"]);
                cmd.Parameters.AddWithValue("@DivisionId", dr["DivisionId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRSection_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRSection_Insert" +
                                        " @Id" +
                                        " , @ModifiedAtUtc" +
                                        " , @CreatedAtUtc" +
                                        " , @SectionName" +
                                        " , @SectionCode" +
                                        " , @SectionNumber" +
                                        " , @DepartmentId";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@SectionName", dr["SectionName"]);
                cmd.Parameters.AddWithValue("@SectionCode", dr["SectionCode"]);
                cmd.Parameters.AddWithValue("@SectionNumber", dr["SectionNumber"]);
                cmd.Parameters.AddWithValue("@DepartmentId", dr["DepartmentId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRClass_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRClass_Insert" +
                                        " @Id" +
                                        " , @ModifiedAtUtc" +
                                        " , @CreatedAtUtc" +
                                        " , @ClassName" +
                                        " , @ClassCode" +
                                        " , @ClassNumber" +
                                        " , @SectionId";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@ClassName", dr["ClassName"]);
                cmd.Parameters.AddWithValue("@ClassCode", dr["ClassCode"]);
                cmd.Parameters.AddWithValue("@ClassNumber", dr["ClassNumber"]);
                cmd.Parameters.AddWithValue("@SectionId", dr["SectionId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PRSubClass_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_PRSubClass_Insert " +
                                        " @Id" +
                                        " , @ModifiedAtUtc" +
                                        " , @CreatedAtUtc" +
                                        " , @SubClassName" +
                                        " , @SubClassCode" +
                                        " , @SubClassNumber" +
                                        " , @ClassId";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@SubClassName", dr["SubClassName"]);
                cmd.Parameters.AddWithValue("@SubClassCode", dr["SubClassCode"]);
                cmd.Parameters.AddWithValue("@SubClassNumber", dr["SubClassNumber"]);
                cmd.Parameters.AddWithValue("@ClassId", dr["ClassId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string POBooking_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_POBooking_Insert" +
                                " @Id" +
                                " , @BookingNo" +
                                " , @VendorId" +
                                " , @AcceptedDateTime" +
                                " , @ModifiedAtUtc" +
                                " , @CreatedAtUtc" +
                                " ";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@BookingNo", dr["BookingNo"]);
                cmd.Parameters.AddWithValue("@VendorId", dr["VendorId"]);
                cmd.Parameters.AddWithValue("@AcceptedDateTime", dr["AcceptedDateTime"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
               
                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string POPurchaseOrder_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "INSERT INTO POPurchaseOrder(" +
                                            " [Id]" +
                                            " ,[ModifiedAtUtc]" +
                                            " ,[CreatedAtUtc]" +
                                            " ,[OrderNumber]" +
                                            " ,[OrderDate]" +
                                            " ,[DeliveryDate]" +
                                            " ,[OrderType]" +
                                            " ,[TimsId]" +
                                            " ,[VendorId]" +
                                            " ,[UploadByUserId]" +
                                            " ,[OrderQuantity]" +
                                            " ,[DigitalQuantity]" +
                                            " ,[SuppliedQuantity]" +
                                            " ,[ContainerCount]" +
                                            " ,[ContainerPackedCount]" +
                                            " ,[StoreCount]" +
                                            " ,[Status]" +
                                            " ,[InvoiceNumber]" +
                                            " ,[LicensePlate]" +
                                            " ,[IssueByUserId]" +
                                            " ,[DcReceiveByUserId]" +
                                            " ,[DcReceiveDate]" +
                                            " ,[VendorIssueDate]" +
                                            " ,[IsQuantityAmended]" +
                                            " ,[DigitalPackByUserId]" +
                                            " ,[DigitalPackDate]" +
                                            " ,[PhysicalPackByUserId]" +
                                            " ,[PhysicalPackDate]" +
                                            " ,[IssueQuantity]" +
                                            " ,[DeleteByUserId]" +
                                            " ,[DeleteDate]" +
                                            " ,[IsDeleted]" +
                                            " ,[OriginalOrderedQuantity]" +
                                            " ,[DigitalPackRevision]" +
                                            " ,[DeliveryPoint]" +
                                            " ,[BookingId]" +
                                            " )" +
                                        " VALUES(" +
                                            " @Id" +
                                            " , @ModifiedAtUtc" +
                                            " , @CreatedAtUtc" +
                                            " , @OrderNumber" +
                                            " , @OrderDate" +
                                            " , @DeliveryDate" +
                                            " , @OrderType" +
                                            " , @TimsId" +
                                            " , @VendorId" +
                                            " , @UploadByUserId" +
                                            " , @OrderQuantity" +
                                            " , @DigitalQuantity" +
                                            " , @SuppliedQuantity" +
                                            " , @ContainerCount" +
                                            " , @ContainerPackedCount" +
                                            " , @StoreCount" +
                                            " , @Status" +
                                            " , @InvoiceNumber" +
                                            " , @LicensePlate" +
                                            " , @IssueByUserId" +
                                            " , @DcReceiveByUserId" +
                                            " , @DcReceiveDate" +
                                            " , @VendorIssueDate" +
                                            " , @IsQuantityAmended" +
                                            " , @DigitalPackByUserId" +
                                            " , @DigitalPackDate" +
                                            " , @PhysicalPackByUserId" +
                                            " , @PhysicalPackDate" +
                                            " , @IssueQuantity" +
                                            " , @DeleteByUserId" +
                                            " , @DeleteDate" +
                                            " , @IsDeleted" +
                                            " , @OriginalOrderedQuantity" +
                                            " , @DigitalPackRevision" +
                                            " , @DeliveryPoint" +
                                            " , @BookingId" +
                                            " )";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@OrderNumber", dr["OrderNumber"]);
                cmd.Parameters.AddWithValue("@OrderDate", dr["OrderDate"]);
                cmd.Parameters.AddWithValue("@DeliveryDate", dr["DeliveryDate"]);
                cmd.Parameters.AddWithValue("@OrderType", dr["OrderType"]);
                cmd.Parameters.AddWithValue("@TimsId", dr["TimsId"]);
                cmd.Parameters.AddWithValue("@VendorId", dr["VendorId"]);
                cmd.Parameters.AddWithValue("@UploadByUserId", dr["UploadByUserId"]);
                cmd.Parameters.AddWithValue("@OrderQuantity", dr["OrderQuantity"]);
                cmd.Parameters.AddWithValue("@DigitalQuantity", dr["DigitalQuantity"]);
                cmd.Parameters.AddWithValue("@SuppliedQuantity", dr["SuppliedQuantity"]);
                cmd.Parameters.AddWithValue("@ContainerCount", dr["ContainerCount"]);
                cmd.Parameters.AddWithValue("@ContainerPackedCount", dr["ContainerPackedCount"]);
                cmd.Parameters.AddWithValue("@StoreCount", dr["StoreCount"]);
                cmd.Parameters.AddWithValue("@Status", dr["Status"]);
                cmd.Parameters.AddWithValue("@InvoiceNumber", dr["InvoiceNumber"]);
                cmd.Parameters.AddWithValue("@LicensePlate", dr["LicensePlate"]);
                cmd.Parameters.AddWithValue("@IssueByUserId", dr["IssueByUserId"]);
                cmd.Parameters.AddWithValue("@DcReceiveByUserId", dr["DcReceiveByUserId"]);
                cmd.Parameters.AddWithValue("@DcReceiveDate", dr["DcReceiveDate"]);
                cmd.Parameters.AddWithValue("@VendorIssueDate", dr["VendorIssueDate"]);
                cmd.Parameters.AddWithValue("@IsQuantityAmended", dr["IsQuantityAmended"]);
                cmd.Parameters.AddWithValue("@DigitalPackByUserId", dr["DigitalPackByUserId"]);
                cmd.Parameters.AddWithValue("@DigitalPackDate", dr["DigitalPackDate"]);
                cmd.Parameters.AddWithValue("@PhysicalPackByUserId", dr["PhysicalPackByUserId"]);
                cmd.Parameters.AddWithValue("@PhysicalPackDate", dr["PhysicalPackDate"]);
                cmd.Parameters.AddWithValue("@IssueQuantity", dr["IssueQuantity"]);
                cmd.Parameters.AddWithValue("@DeleteByUserId", dr["DeleteByUserId"]);
                cmd.Parameters.AddWithValue("@DeleteDate", dr["DeleteDate"]);
                cmd.Parameters.AddWithValue("@IsDeleted", dr["IsDeleted"]);
                cmd.Parameters.AddWithValue("@OriginalOrderedQuantity", dr["OriginalOrderedQuantity"]);
                cmd.Parameters.AddWithValue("@DigitalPackRevision", dr["DigitalPackRevision"]);
                cmd.Parameters.AddWithValue("@DeliveryPoint", dr["DeliveryPoint"]);
                cmd.Parameters.AddWithValue("@BookingId", dr["BookingId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PCContainer_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "INSERT INTO PCContainer(" +
                                            " [Id]" +
                                            " ,[ModifiedAtUtc]" +
                                            " ,[CreatedAtUtc]" +
                                            " ,[ContainerId]" +
                                            " ,[StoreNumber]" +
                                            " ,[OrderNumber]" +
                                            " ,[VendorId]" +
                                            " ,[BoxNo]" +
                                            " ,[BoxCount]" +
                                            " ,[Status]" +
                                            " ,[ReceivedByStoreId]" +
                                            " ,[ReceivedDateTime]" +
                                            " ,[RemarkCode]" +
                                            " ,[DcBol]" +
                                            " ,[DcMasterContainerId]" +
                                            " )" +
                                        " VALUES(" +
                                            " @Id" +
                                            " , @ModifiedAtUtc" +
                                            " , @CreatedAtUtc" +
                                            " , @ContainerId" +
                                            " , @StoreNumber" +
                                            " , @OrderNumber" +
                                            " , @VendorId" +
                                            " , @BoxNo" +
                                            " , @BoxCount" +
                                            " , @Status" +
                                            " , @ReceivedByStoreId" +
                                            " , @ReceivedDateTime" +
                                            " , @RemarkCode" +
                                            " , @DcBol" +
                                            " , @DcMasterContainerId" +
                                            " )";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@ContainerId", dr["ContainerId"]);
                cmd.Parameters.AddWithValue("@StoreNumber", dr["StoreNumber"]);
                cmd.Parameters.AddWithValue("@OrderNumber", dr["OrderNumber"]);
                cmd.Parameters.AddWithValue("@VendorId", dr["VendorId"]);
                cmd.Parameters.AddWithValue("@BoxNo", dr["BoxNo"]);
                cmd.Parameters.AddWithValue("@BoxCount", dr["BoxCount"]);
                cmd.Parameters.AddWithValue("@Status", dr["Status"]);
                cmd.Parameters.AddWithValue("@ReceivedByStoreId", dr["ReceivedByStoreId"]);
                cmd.Parameters.AddWithValue("@ReceivedDateTime", dr["ReceivedDateTime"]);
                cmd.Parameters.AddWithValue("@RemarkCode", dr["RemarkCode"]);
                cmd.Parameters.AddWithValue("@DcBol", dr["DcBol"]);
                cmd.Parameters.AddWithValue("@DcMasterContainerId", dr["DcMasterContainerId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string PCContainerItem_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "INSERT INTO PCContainerItem(" +
                                " [Id]" +
                                " ,[ModifiedAtUtc]" +
                                " ,[CreatedAtUtc]" +
                                " ,[ProductSku]" +
                                " ,[DigitalQuantity]" +
                                " ,[ContainerId]" +
                                " ,[IsReceiveSuccess]" +
                                " ,[IssuedQuantity]" +
                                " ,[StoreReceivedQuantity]" +
                                " )" +
                            " VALUES(" +
                                " @Id" +
                                " , @ModifiedAtUtc" +
                                " , @CreatedAtUtc" +
                                " , @ProductSku" +
                                " , @DigitalQuantity" +
                                " , @ContainerId" +
                                " , @IsReceiveSuccess" +
                                " , @IssuedQuantity" +
                                " , @StoreReceivedQuantity" +
                                " )";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@ProductSku", dr["ProductSku"]);
                cmd.Parameters.AddWithValue("@DigitalQuantity", dr["DigitalQuantity"]);
                cmd.Parameters.AddWithValue("@ContainerId", dr["ContainerId"]);
                cmd.Parameters.AddWithValue("@IsReceiveSuccess", dr["IsReceiveSuccess"]);
                cmd.Parameters.AddWithValue("@IssuedQuantity", dr["IssuedQuantity"]);
                cmd.Parameters.AddWithValue("@StoreReceivedQuantity", dr["StoreReceivedQuantity"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string LOArea_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_LOArea_Insert" +
                                    " @Id" +
                                    " , @Name" +
                                    " , @Code" +
                                    " , @CompanyId" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@Name", dr["Name"]);
                cmd.Parameters.AddWithValue("@Code", dr["Code"]);
                cmd.Parameters.AddWithValue("@CompanyId", dr["CompanyId"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string LOSubArea_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_LOSubArea_Insert" +
                                    " @Id" +
                                    " , @Name" +
                                    " , @Code" +
                                    " , @AreaId" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@Name", dr["Name"]);
                cmd.Parameters.AddWithValue("@Code", dr["Code"]);
                cmd.Parameters.AddWithValue("@AreaId", dr["AreaId"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string LOVendorZone_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_LOVendorZone_Insert" +
                                    " @Id" +
                                    " , @Name" +
                                    " , @Code" +
                                    " , @CompanyId" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@Name", dr["Name"]);
                cmd.Parameters.AddWithValue("@Code", dr["Code"]);
                cmd.Parameters.AddWithValue("@CompanyId", dr["CompanyId"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        public static string LOVendorLocation_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "exec sp_LOVendorLocation_Insert" +
                                    " @Id" +
                                    " , @VendorZoneId" +
                                    " , @SubAreaId" +
                                    " , @ModifiedAtUtc" +
                                    " , @CreatedAtUtc";

                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@VendorZoneId", dr["VendorZoneId"]);
                cmd.Parameters.AddWithValue("@SubAreaId", dr["SubAreaId"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }


        public static string PRProductItem_Save_Local(DataRow dr)
        {
            if (dr == null) return "";

            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = dbValues.dbl_connectionstring;
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                SqlParameter param = new SqlParameter();

                string sql = "INSERT INTO PRProductItem(" +
                                        " [Id]" +
                                        " ,[ModifiedAtUtc]" +
                                        " ,[CreatedAtUtc]" +
                                        " ,[ItemUniqueId]" +
                                        " ,[ProductSku]" +
                                        " ,[VendorId]" +
                                        " ,[ContainerItemId]" +
                                        " ,[Status]" +
                                        " ,[VendorLocationId]" +
                                        " )" +
                                    " VALUES(" +
                                        " @Id" +
                                        " , @ModifiedAtUtc" +
                                        " , @CreatedAtUtc" +
                                        " , @ItemUniqueId" +
                                        " , @ProductSku" +
                                        " , @VendorId" +
                                        " , @ContainerItemId" +
                                        " , @Status" +
                                        " , @VendorLocationId" +
                                        " )";



                cmd.Connection = conn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Id", dr["Id"]);
                cmd.Parameters.AddWithValue("@ModifiedAtUtc", dr["ModifiedAtUtc"]);
                cmd.Parameters.AddWithValue("@CreatedAtUtc", dr["CreatedAtUtc"]);
                cmd.Parameters.AddWithValue("@ItemUniqueId", dr["ItemUniqueId"]);
                cmd.Parameters.AddWithValue("@ProductSku", dr["ProductSku"]);
                cmd.Parameters.AddWithValue("@VendorId", dr["VendorId"]);
                cmd.Parameters.AddWithValue("@ContainerItemId", dr["ContainerItemId"]);
                cmd.Parameters.AddWithValue("@Status", dr["Status"]);
                cmd.Parameters.AddWithValue("@VendorLocationId", dr["VendorLocationId"]);

                cmd.ExecuteNonQuery();


                conn.Close();
                return "";
            }
            catch (Exception ex)
            {
                conn.Close();

                return ex.Message;
            }
        }

        #endregion






    }
}
