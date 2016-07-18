using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        ICinemaRepository repository;

        public AdminController(ICinemaRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index()
        {
            return View(repository.Cinemas);
        }
        public ViewResult Edit(int cinemaId)
        {
            Cinema cinema = repository.Cinemas
                .FirstOrDefault(g => g.CinemaId == cinemaId);
            return View(cinema);
        }

        [HttpPost]
        public ActionResult Edit(Cinema cinema, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    cinema.ImageMimeType = image.ContentType;
                    cinema.ImageData = new byte[image.ContentLength];
                    image.InputStream.Read(cinema.ImageData, 0, image.ContentLength);
                }
                repository.SaveCinema(cinema);
                TempData["message"] = string.Format("Изменения в  \"{0}\" были сохранены",cinema.CinemaName);
                return RedirectToAction("Index");
            }
            else
            {
                // Что-то не так со значениями данных
                return View(cinema);
            }
        }

        public ViewResult Create()
        {
            return View("Edit", new Cinema());
        }

        [HttpPost]
        public ActionResult Delete(int CinemaId)
        {
            Cinema deletedGame = repository.DeleteCinema(CinemaId);
            if (deletedGame != null)
            {
                TempData["message"] = string.Format("Фильм \"{0}\" был удален",
                    deletedGame.CinemaName);
            }
            return RedirectToAction("Index");
        }
	}
}