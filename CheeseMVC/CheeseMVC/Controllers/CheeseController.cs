using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheeese newCheese)
        {
            
            CheeseData.Add(newCheese);
            return Redirect("/Cheese");
        }

        public IActionResult Remove()
        {
            ViewBag.Title = "Remove Cheeses";
            ViewBag.Cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult Remove(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            return Redirect("/Cheese");
        }

        public IActionResult Edit(int cheeseId)
        {
            ViewBag.Cheeses = CheeseData.GetById(cheeseId);
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Edit")]
        public IActionResult Edit(int cheeseId, string name, string description)
        {

            Cheeese toEdit = CheeseData.GetById(cheeseId);
            toEdit.Name = name;
            toEdit.Description = description;

            return Redirect("/Cheese");
        }
         
    }
}
