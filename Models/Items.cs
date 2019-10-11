using System.Collections.Generic;

namespace VendorOrder.Models
{
    public class Order{
        public string VendorName {get; set;}
        public string VenderDescription {get; set;}
        public string OrderedGoods {get; set;}
        public int Id {get;}

        private static List<Order> _Orders = new List<Order>();

        public Order(string vendorName, string orderedGoods)
        {
            VendorName = vendorName;
            OrderedGoods = orderedGoods;
            _Orders.Add(this);
        }
    }
}