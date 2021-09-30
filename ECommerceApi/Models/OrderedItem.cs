using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Models
{
    public class OrderedItem
    {
        public int Id { get; set; }
        public int OrderedQty { get; set; }
        public double PerUnitPrice { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
