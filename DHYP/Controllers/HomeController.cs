using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DHYP.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult yeniIsBildirimi()
    {
      return View();
    }

   public ActionResult IsBildirimiDetay()
   {
     return View();
   }

   public ActionResult IsBildirimListesi()
   {
     return View();
   }

   public ActionResult TeknikPersonelIsBildirimListesi()
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
  }
}
