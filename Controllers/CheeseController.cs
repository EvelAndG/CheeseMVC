using Microsoft.AspNetCore.Mvc;

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

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(string name, string description)
        {
            ViewBag.cheeses = Cheeses;

            Cheeses.Remove(name);
            return Redirect("/Cheese");

        }



    }
}
