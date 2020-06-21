using _91APPTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _91APPTest.Controllers
{
    public class HomeController : Controller
    {
        TestDbEntities db = new TestDbEntities();


        public ActionResult Index()
        {
            


            return View(db.OrderList.OrderBy(x=>x.orderItem));
        }


        public ActionResult Detailed() {

            
            return View();
        }


        [HttpPost]
        public ActionResult saveChange(List<string> list) {

            foreach (var x in list) {
                var change = db.OrderList.Where(id => id.orderId == x).First();
                change.status = 2;}
            db.SaveChanges();
            return null;
        }

        [HttpPost]
        public JsonResult getDetailedData(string data) {
            var detailed = db.ItemDetail.Where(x => x.name == data).First();

            return Json(detailed);
        }

        



    }
}