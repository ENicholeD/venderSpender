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

        }

        [HttpGet("/orders/new_vender")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/orders/new_order")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/orders")]
        public ActionResult Index()
        {

        }

        [HttpGet("/places/{id}")]
        public ActionResult Index()
        {

        }
    }
}