using ExamenAdo.BLL;
using ExamenAdo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamenAdo.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private ParticipantManager participantManager;
        public HomeController()
        {
            participantManager = new ParticipantManager();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MemberList()
        {
            return View();
        }

        public ActionResult MemberDetail()
        {
            return View();
        }

        public ActionResult MemberCreate()
        {
            return View();
        }
    }
}