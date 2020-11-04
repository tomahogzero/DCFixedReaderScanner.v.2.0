using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class model_contrainer
    {
        public string containerId { get; set; }
        public string status { get; set; }
        public int boxNo { get; set; }
        public int boxCount { get; set; }
        public string storeNumber { get; set; }
        public int suppliedQuantity { get; set; }
        public int digitalQuantity { get; set; }
        public string orderNumber { get; set; }
        public int containerPackedCountInPo { get; set; }
        public List<model_contrainerItems> containerItems { get; set; }
        public string id { get; set; }
        public DateTime modifiedAtUtc { get; set; }
        public DateTime createdAtUtc { get; set; }
    }

    public class model_contrainerItems
    {
        public string productSku { get; set; }
        public string upc { get; set; }
        public string itemNo { get; set; }
        public string styleNo { get; set; }
        public string description { get; set; }
        public string colorCode { get; set; }
        public string sizeType { get; set; }
        public int suppliedQuantity { get; set; }
        public int digitalQuantity { get; set; }
        public string[] productItems { get; set; }
        public string[] itemUniqueIds { get; set; }
    }

}
