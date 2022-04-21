using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {


        static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();
        

        public IActionResult Index()
        {
           ViewBag.cheeses = Cheeses;

            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            //Add new cheese to existing cheeses
            //Takes two paramaters (name & description)
            Cheeses.Add(name, description);
            return Redirect("/Cheese");

        }


        //[HttpPost]
        //[Route("/Cheese/Remove")]
        public IActionResult Remove(string name, string description)
        {
            ViewBag.cheeses = Cheeses;  

            return View();

        }

        [Route("/Cheese/Remove")]
        [HttpPost]       
        public IActionResult RemoveCheese(string cheeseName, string description)
        {
            ViewBag.cheeses = Cheeses;
            Cheeses.Remove(cheeseName);
            return Redirect("/Cheese");

        }



    }
}
