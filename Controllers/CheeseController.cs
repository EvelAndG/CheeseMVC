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


        
    }
}
