using BookingManager.Hubs;
using BookingManager.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingManager.Controllers
{
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

        [HttpPost]
        public ActionResult CreateEvent(Booking booking)
        {

            var context = GlobalHost.ConnectionManager.GetHubContext<BookingHub>();
            context.Clients.All.updateBooking(booking);  

            return View();
        }
    }
}