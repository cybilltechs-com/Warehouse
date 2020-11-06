using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WarehouseManagementSystem.Models;

namespace WarehouseManagementSystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Main()
        {
            return View();
        }
       [HttpPost]
        public ActionResult Add_Profile(Admin admindetails,FormCollection formCollection)
        {
            var ProfileImage = Request.Files;
            string imgname = string.Empty;
            string ImageName = string.Empty;


            //Following code will check that image is there 
            //If it will Upload or else it will use Default Image

            if (System.Web.HttpContext.Current.Request.Files.AllKeys.Any())
            {
                var logo = System.Web.HttpContext.Current.Request.Files["file"];
                if (logo.ContentLength > 0)
                {
                    var profileName = Path.GetFileName(logo.FileName);
                    var ext = Path.GetExtension(logo.FileName);

                    ImageName = profileName;
                    var comPath = Server.MapPath("/images/") + ImageName;

                    logo.SaveAs(comPath);
                    admindetails.ProfileImage = comPath;
                }


            }
            else
            {
                admindetails.ProfileImage = Server.MapPath("/images/") + "profile.jpg";
            }

            int response = 1;
            return Json(response, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Add_Item()
        {
            return View();
        }
        public ActionResult Add_Purchase_Order()
        {
            return View();
        }
        public ActionResult Add_Sales_Order()
        {
            return View();
        }
        public ActionResult Add_Stock()
        {
            return View();
        }
        public ActionResult Add_Subincharge()
        {
            return View();
        }
        public ActionResult Add_SubLocation()
        {
            return View();
        }
        public ActionResult Add_Supplier()
        {
            return View();
        }
        public ActionResult Add_Supplier12()
        {
            return View();
        }
        public ActionResult Add_Purchase_Orders()
        {
            return View();
        }
        public ActionResult All_Items()
        {
            return View();
        }
        public ActionResult All_Reports_Item()
        {
            return View();
        }
        public ActionResult All_Reports_Purchase()
        {
            return View();
        }
        public ActionResult All_Reports_Retailer()
        {
            return View();
        }
        public ActionResult All_Reports_SalesOrder()
        {
            return View();
        }
        public ActionResult All_Reports_Stock()
        {
            return View();
        }
        public ActionResult All_Reports_SubIncharge()
        {
            return View();
        }
        public ActionResult All_Reports_Supplier()
        {
            return View();
        }
        public ActionResult All_Retailers()
        {
            return View();
        }
        public ActionResult All_SalesOrders()
        {
            return View();
        }
        public ActionResult All_Stock()
        {
            return View();
        }
        public ActionResult All_Subincharge()
        {
            return View();
        }
        public ActionResult All_Suppliers()
        {
            return View();
        }
        public ActionResult Data_Tables()
        {
            return View();
        }
        public ActionResult Forms_Validation()
        {
            return View();
        }




    }
}