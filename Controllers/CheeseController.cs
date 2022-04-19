using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {


        static private List<string> Cheeses = new List<string>();

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
        public IActionResult NewCheese(string name)
        {
            //Add new cheese to existing cheeses
            Cheeses.Add(name);

            return Redirect("/Cheese");

        }


        //[HttpPost]
        //[Route("/Cheese/Remove")]
        public IActionResult Remove(string name)
        {

            ViewBag.cheeses = Cheeses;

            //Cheeses.Remove(name);
            // return Redirect("/Cheese");
            Cheeses.Remove(name);
            return View();

        }


        
    }
}
