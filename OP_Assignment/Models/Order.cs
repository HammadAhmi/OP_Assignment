using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OP_Assignment.Models
{
    public class Order
    {
        public decimal OrderAmount { get; set; }
        public string CustomerType { get; set; }  // "New" or "Loyal"
        public decimal Discount { get; set; }
        public decimal FinalAmount => OrderAmount - Discount;
    }
}