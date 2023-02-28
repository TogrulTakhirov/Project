using Otomation.Models.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Otomation.Controllers
{
    [Authorize]

    public class UrunDetayController : Controller
    {
        Context c = new Context();
        // GET: UrunDetay
        public ActionResult Index(int id)
        {
            Class1 cs = new Class1();
            cs.deger1 = c.Uruns.Where(x => x.Urunid == 3).ToList();
            cs.deger2 = c.Detays.Where(x => x.DetayId == 1).ToList();
            return View(cs);
        }
    }
}