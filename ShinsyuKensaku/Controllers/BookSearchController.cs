using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShinsyuKensaku.Models;
using ShinsyuKensaku.ViewModels;
using System.Net;

namespace ShinsyuKensaku.Controllers
{
    public class BookSearchController : Controller
    {

        private BooksModel db = new BooksModel();

        // GET: Books1
        //public ActionResult Index()
        //{
        //    // SQL version of the above LINQ code.
        //    string query = "SELECT id "
        //    + ",seq "
        //    + ",title "
        //    + ",heading "
        //    + ",LEFT(body,200) as digest "
        //    + ",body "
        //    + ",link "
        //    + ",division "
        //+ " FROM Books";
        //    IEnumerable<Books> data = db.Database.SqlQuery<Books>(query);

        //    return View(data.ToList());
        //}

        // GET: Books1
        //[ChildActionOnly]
        public ActionResult Index(string keyword)
        {
            // SQL version of the above LINQ code.
            string query = "SELECT id "
            + ",seq "
            + ",title "
            + ",heading "
            + ",LEFT(body,200) as digest "
            + ",body "
            + ",link "
            + ",division "
            + " FROM Books"
            + " WHERE body like N'%"
            + keyword
            + "%'";
            IEnumerable<Books> data = db.Database.SqlQuery<Books>(query);

            //return PartialView("_SearchPartial", data.ToList());
            return View(data.ToList());
        }

        // GET: Books1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            string query = "SELECT id "
            + ",seq "
            + ",title "
            + ",heading "
            + ",LEFT(body,200) as digest "
            + ",body "
            + ",link "
            + ",division "
            + " FROM Books "
            + " WHERE id = "
            + id.ToString();

            IEnumerable<Books> data = db.Database.SqlQuery<Books>(query);

            return View(data.ToList());

        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}