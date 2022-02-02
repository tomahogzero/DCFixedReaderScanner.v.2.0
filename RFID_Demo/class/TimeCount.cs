using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCRFIDReader
{
    public class TimeCount
    {
        public static void set_start(ref DataSet dsPO)
        {
            try
            {
                for (int i = 0; i < dsPO.Tables[0].Rows.Count; i++)
                {
                    DateTime timest = DateTime.Now;
                    dsPO.Tables[0].Rows[i]["start_time"] = timest;
                    dsPO.Tables[0].Rows[i]["stop_time"] = timest;
                    dsPO.Tables[0].Rows[i]["time_st"] = timest.ToString("HH:mm:ss");
                    dsPO.Tables[0].Rows[i]["time_sp"] = timest.ToString("HH:mm:ss");
                    dsPO.Tables[0].Rows[i]["time_count"] = "00:00:00";
                }              
            }
            catch(Exception ex)
            {
                
            }
        }

        public static void update_time_count(ref DataSet dsPO)
        {
            try
            {
                DateTime time_sp = DateTime.Now;

                for (int i = 0; i < dsPO.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = dsPO.Tables[0].Rows[i];

                    

                    if ((int)dr["DigitalQuantity"] > (int)dr["QtyRead"])
                    {
                        var t = (time_sp - (DateTime)dr["start_time"]).TotalSeconds;

                        decimal totalsec = (decimal)t;

                        decimal sec = (int)Math.Floor(totalsec);

                        int h = 0;
                        int m = 0;
                        int s = 0;
                        string time_count = "";

                        h = Convert.ToInt32(Math.Floor(sec / 3600));
                        sec = sec - (h * 3600);

                        m = Convert.ToInt32(Math.Floor(sec / 60));
                        sec = sec - (m * 60);

                        s = Convert.ToInt32(sec);

                        time_count = string.Format("{0,10:D2}",h).Trim() + ":" +
                                        string.Format("{0,10:D2}", m).Trim() + ":" +
                                        string.Format("{0,10:D2}", s).Trim();


                        dr["stop_time"] = time_sp;
                        //dr["time_sp"] = time_sp.ToString("HH:mm:ss");
                        dr["time_count"] = time_count;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

    }
}
