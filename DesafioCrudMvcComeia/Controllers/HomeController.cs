using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesafioCrudMvcComeia.Models;
using System.Net;
using Newtonsoft.Json;
using System.IO;


namespace DesafioCrudMvcComeia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            var url = "https://randomuser.me/api/?results=10";
            WebClient wc = new WebClient();
            var dados = wc.DownloadString(url);
            var rs = JsonConvert.DeserializeObject<Resultado>(dados);

            return View(rs);
            
           
        }

        public ActionResult Contact()
        {
            /*
            var url = "https://randomuser.me/api/?results=1";
            WebClient wc = new WebClient();
            var dados = wc.DownloadString(url);
            var rs = JsonConvert.DeserializeObject<Resultado>(dados);

            return View(rs);
            */
            return View();
        }

    }
}