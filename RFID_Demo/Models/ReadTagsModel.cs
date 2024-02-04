using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCRFIDReader.Models
{
    public class ReadTagsModel
    {
        public string RFID { get; set; }
        public int Antenna { get; set; }
        public bool isProcess { get; set; }
    }
}
