
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
namespace MVC.Controllers
{
    public class MoviesController:Controller
    {
        // Action

        //public string GetMoive(int? id, string name)
        //{
        //    if (id is not null)
        //    {
        //        return $"Movie ---------------{id}/{name}";
        //    }

        //    return "No Moive";
        //}
        //public ContentResult GetMoive(int? id, string name)
        //{
        //    //ContentResult contentResult = new ContentResult();
        //    //contentResult.StatusCode = 9999;
        //    //contentResult.ContentType = "text/html";
        //    //contentResult.Content =$"Movie ---------------{id}/{name}";

        //    //return contentResult;
        //    return Content($"Movie ---------------{id}/{name}", "text/html");

        //}
        public IActionResult GetMoive(int? id, string name)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.StatusCode = 9999;
            //contentResult.ContentType = "text/html";
            //contentResult.Content =$"Movie ---------------{id}/{name}";

            //return contentResult;
            if(id==0)
            {
                return BadRequest();

            }
            else if (id < 10)
            {
                return NotFound();

            }
            else
                return Content($"Movie ---------------{id}/{name}", "text/html");

        }
        public IActionResult Redirect()
        {
            return Redirect("");
        }
        public IActionResult RedirectToGetMovie()
        {
            return RedirectToAction("index", "MovieController",new {id=30,name="x-man"});
        }
        public IActionResult RedirectToRoute()
        {
            return RedirectToRoute("Default");
        }
        public IActionResult TestmodelBinding(int? id, string name)
        {
            return Content($"Movie ---------------{id}/{name}", "text/html");

        }
        public string index (int? id )   
        {

            if (id is not null)
            {
                return $"index ---------------{id}";
            }

            return "No index";
        }
    } 
}
