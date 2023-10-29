using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Differencing;
using System.Diagnostics;
using WebPumpsApp.Data;
using WebPumpsApp.Models;

namespace WebPumpsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly PumpsContext db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, PumpsContext context)
        {
            _logger = logger;
            db = context;
        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AllPumps()
        {
            GivePumps();
            return View();
        }

        private void GivePumps()
        {
            var allPumps = db.Pumps.ToList<Pump>();
            ViewBag.Pumps = allPumps;
        }

        [HttpGet]
        public ActionResult CreateBid()
        {
            GivePumps();
            var allBids = db.Bids.ToList<Bid>();
            ViewBag.Bids = allBids;
            return View();
        }
        [HttpPost]
        public string CreateBid(Bid newBid)
        {
            newBid.bidDate = DateTime.Now;
            db.Bids.Add(newBid);
            db.SaveChanges(); return "Спасибо, " + newBid.Name + ", за выбор " +
                "компании PumpsEquipment. Наши сотрудники свяжутся с вами в ближайшее вермя " +
                "для оформления покупки и уточнения информации";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult PumpSearch(string name)
        {
            var allBids = db.Bids.Where(a => a.PumpHead.Contains(name)).ToList();
            if (allBids.Count == 0)
            {
                return Content("Насос " + name + " не найден");
            }
            return PartialView(allBids);
        }
    }
       
}
    