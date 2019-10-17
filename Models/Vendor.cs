using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    
    public string Name { get; set; }
    public int VendorId { get; set; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public Vendor(string name)
    {
      Name = name;
      _instances.Add(this);
      VendorId = _instances.Count;

    }
    public static List<Vendor> GetAll()
      {
        return _instances;
      }
     public static Vendor Find(int searchID)
        {
            return _instances[searchID-1];
        }
  }
}