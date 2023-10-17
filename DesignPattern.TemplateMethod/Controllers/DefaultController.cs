using DesignPattern.TemplateMethod.TemplaPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            //manuel yöntem
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Film,Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480p");

            //netflixPlans.CreatePlan();
            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandartPlan();
            //manuel yöntem
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(95.99);
            ViewBag.v4 = netflixPlans.Content("Film,Dizi,Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("720p");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            //manuel yöntem
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(135.99);
            ViewBag.v4 = netflixPlans.Content("Film,Dizi,Animasyon,Belgesel");
            ViewBag.v5 = netflixPlans.Resolution("1080p");
            return View();
        }
    }
}
