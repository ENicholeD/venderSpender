using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    
    public string Name { get; set; }
    public string Description {get; set;}
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};
    public Vendor(string desctiption)
    {
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;

    }
    public static List<Vendor> GetAll()
        {
            return _instances;
        }
  }
}