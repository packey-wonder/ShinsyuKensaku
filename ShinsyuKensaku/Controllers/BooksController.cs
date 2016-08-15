using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShinsyuKensaku.DAL;
using ShinsyuKensaku.Models;


namespace ShinsyuKensaku.Controllers
{
    public class BooksController : Controller
    {
        private ShinsyuContext db = new ShinsyuContext();

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            //           };

            // SQL version of the above LINQ code.
            string query = "SELECT id "
            + ",seq "
            + ",title "
            + ",heading "
            + ",body "
            + ",link "
            + ",division "
        + "FROM Books";
            IEnumerable<Book> data = db.Database.SqlQuery<Book>(query);

            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}