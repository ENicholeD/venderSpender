using System.Collections.Generic;

namespace VendorOrder.Models
{
    public class Vendor
    {
        public string VendorName {get; set;}
        public string VenderDescription {get; set;}
        public int VenderId {get;}

        public VendorOrder(string vendorName, string venderDescription)
        {
            VendorName = vendorName;
            VenderDescription = venderDescription;

        }
        public class Order{
            public string OrderedGoods {get; set;}
            public int OrderId {get;}
            private static List<Order> _Orders = new List<Order>();

            public Order(string orderedGoods)
            { 
                OrderedGoods = orderedGoods;
                _Orders.Add(this);
            }

            public static List<Order> GetAll()
            {
                return _Orders;
            }

            public static Order Find(int idSearch)
            {
                return _orders[idSearch-1];
            }
        }
    }
}