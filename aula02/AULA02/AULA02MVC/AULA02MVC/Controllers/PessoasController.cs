using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AULA02MVC.Controllers
{
    public class PessoasController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TitleH1 = "Hello Pessoas";
            return View();
        }
    }
}