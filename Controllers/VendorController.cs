using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;


namespace VendorOrder.Controllers
{
     public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allItems = Vendor.GetAll();
            return View(allItems);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name)
        {
            Vendor SelectedVendor = new Vendor(name);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{vendorId}")]
        public ActionResult Show(int VendorId)
        {
            Vendor foundVendor = Vendor.Find(VendorId);
            return View(foundVendor);
        }
    }
}