using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DCRFIDReader
{
    public class aconfig
    {
        public static string getconnecctionstring()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["dbConnection"].ToString();
        }

        public static string AutoStart()
        {
            return System.Configuration.ConfigurationManager.AppSettings["AutoStart"].Trim();
        }

        public static int ResetBuffer_Min()
        {
            return int.Parse(System.Configuration.ConfigurationManager.AppSettings["ResetBuffer_Min"]);
        }

        //public static string StartReaderForTest()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["StartReaderForTest"].Trim();
        //}

        //public static string dbl_servername()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbl_servername"].Trim();
        //}
        //public static string dbl_databasename()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbl_databasename"].Trim();
        //}

        //public static string dbl_uid()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbl_uid"].Trim();
        //}

        //public static string dbl_pwd()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbl_pwd"].Trim();
        //}

        //public static string dbr_servername()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbr_servername"].Trim();
        //}
        //public static string dbr_databasename()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbr_databasename"].Trim();
        //}
        //public static string dbr_uid()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbr_uid"].Trim();
        //}
        //public static string dbr_pwd()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["dbr_pwd"].Trim();
        //}
        //public static string url_api_id()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["url_api_id"].Trim();
        //}
        //public static string url_api_app()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["url_api_app"].Trim();
        //}
        //public static string reader_ip()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["reader_ip"].Trim();
        //}
        //public static string reader_port()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["reader_port"].Trim();
        //}
        //public static string api_username()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["api_username"].Trim();
        //}
        //public static string api_password()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["api_password"].Trim();
        //}
        //public static string gate()
        //{
        //    return System.Configuration.ConfigurationManager.AppSettings["gate"].Trim();
        //}
    }
}
