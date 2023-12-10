using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUplods.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {



            return View();
        }
        [HttpPost]

        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            string filename=Path.GetFileName(postedFile.FileName);
            string filepath = "!/Uploads/" + filename;
            postedFile.SaveAs(Server.MapPath(filepath));

            return RedirectToAction("Index");

        }
    }
}