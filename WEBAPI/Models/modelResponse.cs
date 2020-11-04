using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{

   public class modelResult
    {
        public int code { get; set; }
        public object data { get; set; }
        public object page { get; set; }
        public string desc { get; set; }
        public int timecost { get; set; }
    }

    public class modelResultError
    {
        public int message { get; set; }
        public string title { get; set; }
    }

    public class modelResultUploadImage
    {
        public int code { get; set; }
        public modelDataUploadImage data { get; set; }
        public object page { get; set; }
        public string desc { get; set; }
        public int timecost { get; set; }
    }

    public class modelResultSubject
    {
        public int code { get; set; }
        public List<modelSubject> data { get; set; }
        public object page { get; set; }
        public string desc { get; set; }
        public int timecost { get; set; }
    }

    public class modelResultRegisterEmployee
    {
        public int code { get; set; }
        public object data { get; set; }
        public object page { get; set; }
        public string desc { get; set; }
        public int timecost { get; set; }
    }
}
