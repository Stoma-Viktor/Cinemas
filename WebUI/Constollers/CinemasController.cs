using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class CinemasController : Controller
    {
         private ICinemaRepository repository;
         public int pageSize = 6;
         public CinemasController(ICinemaRepository repo)
        {
            repository = repo;
        }
         public ViewResult List(string category, int page = 1)
         {
              CinemasListViewModel model = new CinemasListViewModel
            {
                Cinemas = repository.Cinemas
                .Where(b => category == null || b.Category == category )
                 .OrderBy(Cinema => Cinema.CinemaId)
                 .Skip((page-1)*pageSize)
                 .Take(pageSize),
                 PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems =category == null ? 
                    repository.Cinemas.Count(): 
                    repository.Cinemas.Where(p => p.Category == category).Count()
                },
                CurrentCategory = category
            }; 
              return View(model);
            }            
	}
}

