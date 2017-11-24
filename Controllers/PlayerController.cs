using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using cricket.Models;

namespace cricket.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        SqlConnection Connection = new SqlConnection("Server = .\\SQLEXPRESS; Initial Catalog=dbCricket; Integrated Security= sspi;");
        SqlCommand Command;
     //   SqlDataReader Reader;
        String Query = "";
        Int32 RowsAffected = 0;

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddPlayer()
        {
            return View();
        }
        public ActionResult Teams()
        {
            return View();
        }
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult India()
        {
            return View();
        }
        public ActionResult Australia()
        {
            return View();
        }
        public ActionResult Southafrica()
        {
            return View();
        }
        public ActionResult England()
        {
            return View();
        }

        public ActionResult Nz()
        {
            return View();
        }
        public ActionResult SriLanka()
        {
            return View();
        }
        public ActionResult Pakistan()
        {
            return View();
        }
        public ActionResult WestIndies()
        {
            return View();
        }
        public ActionResult Bangladesh()
        {
            return View();
        }
        public ActionResult Zimbabwe()
        {
            return View();
        }
        public ActionResult Afghanistan()
        {
            return View();
        }
        public ActionResult Photos()
        {
            return View();
        }
        public ActionResult Rankings()
        {
            return View();
        }

    }
}