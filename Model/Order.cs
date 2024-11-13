using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class Order
    {
        public int OrderName { get; set; }
        public string price { get; set; }
        public string Qnty { get; set; }
        public string UserEmail { get; set; }
        public string UserVisa { get; set; }
        public string UserId { get; set; }
    }
}
