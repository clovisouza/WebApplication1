using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class Categoria
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

    }

    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public JsonResult getcategories()
        {
            IList<Categoria> Lista = new List<Categoria>();
            Lista.Add(new Categoria{
                 CategoryID=1,
                 CategoryName="ASP.NET"
            });

            Lista.Add(new Categoria{
                CategoryID = 2,
                CategoryName = "C#"
            });

            Lista.Add(new Categoria{
                CategoryID = 3,
                CategoryName = "JAVA"
            });

            Lista.Add(new Categoria{
                CategoryID = 4,
                CategoryName = "NODE"
            });

            return new JsonResult { Data = Lista, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            //using (MyDatabaseEntities dc = new MyDatabaseEntities())
            //{
            //    return new JsonResult { Data = dc.Categories.ToList(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            //}
        }


        [HttpPost]
        public JsonResult savedata(int[] categoryIds)
        {
            //for make the application simple I am just sending back the selected categories from here
            // but you can do additional work here with categoryIds parameter
            //List<Category> list = new List<Category>();
            //if (categoryIds != null)
            //{
            //    using (MyDatabaseEntities dc = new MyDatabaseEntities())
            //    {
            //        list = dc.Categories.Where(a => categoryIds.Contains(a.CategoryID)).ToList();
            //    }

            //    // do your additional work here
            //}
            //return new JsonResult { Data = list };
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}