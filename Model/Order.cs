    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Order
    {
        public string order_date { get; set; } 
        public string order_status { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public string user_email { get; set; }
        public string visa_number { get; set; }
        public int item_id { get; set; }
    }
}
