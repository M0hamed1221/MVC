using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        /*BaseURL/Home/index(Action)*/
        public IActionResult Index()
        {
            return View();// Retrun view with the same name as the action name
            //return View(new Movie());// Retrun view with the same name as the action name and BIND the Model
            //return View("MKM");// Retrun view with the Provided name as the action name
            //return View("MKM", new Movie());
        }
        public IActionResult Privacy()
        {
            return View();
            
        }
        public IActionResult About()
        {
            return View();

        }
        public IActionResult Contact()
        {
            return View();

        }
    }
}
