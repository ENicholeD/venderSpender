using System.Collections.Generic;

namespace VendorOrder.Models
{
    public class Order{
        public string Ordered {get; set;}
        public int Amount {get; set;}
        public int Id {get;}
        private static List<Order> _Orders = new List<Order>();

        public Order(string ordered, int amount)
        { 
            Ordered = Ordered;
            Amount = amount;
            _Orders.Add(this);
            Id = _Orders.Count;
        }

        public static List<Order> GetAll()
        {
            return _Orders;
        }
         public static void ClearAll()
        {
            _Orders.Clear();
        }
        public static Order Find(int searchID)
        {
            return _Orders[searchID-1];
        }
    }
}