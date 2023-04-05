using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Order.Models
{
    public class Sales
    {
        public int ID { get; set; }
        [Required]
        public string SalesOrder { get; set; }
        [Required]
        public string SalesOrderItem { get; set; }
        [Required]
        public string WorkOrder { get; set; }
        [Required]
        public string ProductID { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:#}")]
        public decimal OrderQuantity { get; set; } 
        [Required]
        public string OrderStatus { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
    }
}
