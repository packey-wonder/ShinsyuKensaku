using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShinsyuKensaku.Models;
using ShinsyuKensaku.ViewModels;

namespace ShinsyuKensaku.Controllers
{
    public class BookSearchController : Controller
    {

        //public ActionResult Index()
        //{
        //    return View();
        //}

        private BooksModel db = new BooksModel();
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
        + " FROM Books";
            IEnumerable<Books> data = db.Database.SqlQuery<Books>(query);

            return View(data.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}