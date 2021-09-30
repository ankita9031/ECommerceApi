using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Status { get; set; }
        public double TotalPrice { get; set; }
        public ICollection<OrderedItem> OrderedItems { get; set; }
    }
}
