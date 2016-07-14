using Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    public class CinemasController : Controller
    {
         private ICinemaRepository repository;
         public CinemasController(ICinemaRepository repo)
        {
            repository = repo;
        }
         public ViewResult List()
         {
             return View(repository.Cinemas);
         }
	}
}

namespace WebUI.Controllers
{
    public class CinemasController : Controller
    {
        private ICinemaRepository repository;
        public CinemasController(ICinemaRepository repo)
        {
            repository = repo;
        }
        public ViewResult List()
        {
            return View(repository.Cinemas);
        }
    }
}