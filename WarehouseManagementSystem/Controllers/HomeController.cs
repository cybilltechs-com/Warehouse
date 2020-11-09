using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarehouseManagementSystem.DataAccessLayer;
using WarehouseManagementSystem.Models;


namespace WarehouseManagementSystem.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection form)
        {


            if (ModelState.IsValid)
            {
                string name = form["name"];
                string password = form["pwd"];
                string logintype = form["ltype"];
                List<Admin> user = new List<Admin>();
                DataAccessCredentials dac = new DataAccessCredentials();
                AdminProfile ap = new AdminProfile();
                user = ap.LoginCheck(name, name, password, logintype);
                if (user != null)
                {
                    return this.RedirectToAction("Main", "Admin");
                }
            }
            return View();

             
        }

        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Blog_left()
        {
            return View();
        }

        public ActionResult Faq()
        {
            return View();
        }
        public ActionResult Career()
        {
            return View();
        }
        public ActionResult Company_history()
        {
            return View();
        }
        public ActionResult Fleet_gallery_1()
        {
            return View();
        }
        public ActionResult Fleet_gallery_2()
        {
            return View();
        }
        public ActionResult Request_quote()
        {
            return View();
        }
        public ActionResult Service()
        {
            return View();
        }
        public ActionResult Single_service()
        {
            return View();
        }
        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Testmonials()
        {
            return View();
        }
        public ActionResult Track_shipment()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Clients()
        {
            return View();
        }

    }
}