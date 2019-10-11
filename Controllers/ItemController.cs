using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Order.GetAll();
            return View(allOrders);
        }

        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/orders")]
        public ActionResult Create(string description)
        {
            Vendor SelectedVendor = new Vendor(description);
            return RedirectToAction("Index");
        }

        [HttpGet("/places/{id}")]
        public ActionResult Show(int id)
        {
            Order FoundOrder = Order.Find(id);
            return View(FoundOrder);
        }
    }
}