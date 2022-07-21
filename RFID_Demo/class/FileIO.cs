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
using webAPI.Models;

public class cFileIO
{
    public static void WriteLogToFile(string strToWrite)
    {
        System.IO.StreamWriter stream = null;
        try
        {
            string fileName = "Log-" + DateTime.Now.Date.ToString("yyyyMMdd"); // Strings.Format(DateTime.Now.Date, "yyyyMMdd");
            stream = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Log\" + fileName + ".txt",true);

            stream.WriteLineAsync(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " " + strToWrite);
            stream.Flush();
            stream.Close();
        }
        catch (Exception ex)
        {
        }
    }

    public static void WriteLogToFile(string Name, string strToWrite)
    {
        System.IO.StreamWriter stream = null;
        try
        {
            string fileName = "Log-" + Name + "-" + DateTime.Now.Date.ToString("yyyyMMdd"); // Strings.Format(DateTime.Now.Date, "yyyyMMdd");
            stream = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Log\" + fileName + ".txt", true);

            stream.WriteLineAsync(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + " " + strToWrite);
            stream.Flush();
            stream.Close();
        }
        catch (Exception ex)
        {
        }
    }
}
