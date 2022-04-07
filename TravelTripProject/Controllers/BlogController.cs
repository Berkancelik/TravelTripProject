using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;
namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        public ActionResult Index()
        {
            var blogs = c.Blogs.ToList();
            return View(blogs);
        }

        public ActionResult BlogDetay(int id)
        {
            return View();
        }
    }
}