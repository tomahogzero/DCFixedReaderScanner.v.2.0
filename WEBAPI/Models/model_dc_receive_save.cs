using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    class model_dc_receive_save
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class container_epc
        {
            public string containerId { get; set; }
            public List<string> itemUniqueIds { get; set; }
        }

        public class Root
        {
            public List<container_epc> container_epcs { get; set; }
        }
    }
}
