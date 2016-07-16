using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class NavController : Controller
    {
        private ICinemaRepository repository;

        public NavController(ICinemaRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;


            IEnumerable<string> categories = repository.Cinemas
                .Select(p => p.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
        
	}
}