using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestHub.Areas.ProductManagement.Controllers
{
    public class ProductManagementHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}