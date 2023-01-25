//Name: Ankita Sumeet 
//Date: 09/23/22
//Description: HW2 – Bookstore Checkout 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sumeet_Ankita_HW2.Models;
using static Sumeet_Ankita_HW2.Models.Order;

namespace Sumeet_Ankita_HW2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckoutDirect()
        {
            return View();
        }

        public IActionResult DirectTotals(DirectOrder directOrder)
        {
            TryValidateModel(directOrder);

            if (ModelState.IsValid == false)
            {
                ViewBag.Error = "Please enter valid data!";
                return View("CheckoutDirect", directOrder);
            }

            directOrder.CustomerType = CustomerType.Direct;

            directOrder.CalcTotals();

            return View(directOrder);
        }

        public IActionResult CheckoutWholesale()
        {
            return View();
        }

        public IActionResult WholesaleTotals(WholesaleOrder wholesaleOrder)
        {
            TryValidateModel(wholesaleOrder);

            if (ModelState.IsValid == false)
            {
                ViewBag.Error = "Please enter valid data!";
                return View("CheckoutWholesale", wholesaleOrder);
            }

            wholesaleOrder.CustomerType = CustomerType.Wholesale;

            wholesaleOrder.CalcTotals();

            return View(wholesaleOrder);
        }
    }
}

