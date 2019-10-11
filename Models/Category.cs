using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string VendorDescription {get; set;}
    public int Id { get; }
    public Vendor(string name)
    {
      Name = name;

    }
    public static List<Vendor> GetAll()
        {
            return _instances;
        }
  }
}