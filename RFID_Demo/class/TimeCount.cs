using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_RFID3_Host_Sample1
{
    public class TimeCount
    {
        public static void set_start(ref DataSet dsPO)
        {
            try
            {
                for (int i = 0; i < dsPO.Tables[0].Rows.Count; i++)
                {
                    dsPO.Tables[0].Rows[i]["start_time"] = DateTime.Now;
                    dsPO.Tables[0].Rows[i]["stop_time"] = DateTime.Now;
                    dsPO.Tables[0].Rows[i]["time_count"] = "00:00:00";
                }              
            }
            catch
            {

            }
        }

        public static void update_time_count(ref DataSet dsPO)
        {
            try
            {
                for (int i = 0; i < dsPO.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = dsPO.Tables[0].Rows[i];

                    if ((int)dr["DigitalQuantity"] > (int)dr["QtyRead"])
                    {
                        var t = (DateTime.Now - (DateTime)dr["start_time"]).TotalSeconds;

                        decimal sec = (decimal)t;

                        decimal h = 0;
                        decimal m = 0;
                        decimal s = 0;
                        string time_count = "";

                        h = Math.Ceiling(sec / 3600);
                        sec = sec - (h * 3600);

                        m = Math.Ceiling(sec / 60);
                        sec = sec - (m * 60);

                        s = sec;

                        time_count = string.Format("{0,10:D2}",h) + ":" +
                                        string.Format("{0,10:D2}", m) + ":" +
                                        string.Format("{0,10:D2}", s);

                        dr["stop_time"] = DateTime.Now;
                        dr["time_count"] = time_count;
                    }
                }
            }
            catch
            {

            }
        }

    }
}
