using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string VendorDescription {get; set;}
    public int Id { get; }
    private List<Order> _venderOrders { get; set; }
    public Vendor(string name, string vendorDescription)
    {
      Name = name;
      VendorDescription = vendorDescription;

    }
    public static List<Vendor> GetAll()
        {
            return _venderOrders;
        }
  }
}