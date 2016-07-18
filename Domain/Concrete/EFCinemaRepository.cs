using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Concrete
{
    public class EFCinemaRepository : ICinemaRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Cinema> Cinemas
        {
            get { return context.Cinemas; }
        }

        public Cinema DeleteCinema(int CinemaId)
        {
            Cinema dbEntry = context.Cinemas.Find(CinemaId);
            if (dbEntry != null)
            {
                context.Cinemas.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
        public void SaveCinema(Cinema cinema)
        {
            if (cinema.CinemaId == 0)
                context.Cinemas.Add(cinema);
            else
            {
                Cinema dbEntry = context.Cinemas.Find(cinema.CinemaId);
                if (dbEntry != null)
                {
                    dbEntry.CinemaName = cinema.CinemaName;
                    dbEntry.Artors = cinema.Artors;
                    dbEntry.Country = cinema.Country;
                    dbEntry.Directors = cinema.Directors;
                    dbEntry.time = cinema.time;
                    dbEntry.Year = cinema.Year;
                    dbEntry.Description = cinema.Description;
                    dbEntry.Price = cinema.Price;
                    dbEntry.Category = cinema.Category;
                    dbEntry.ImageData = cinema.ImageData;
                    dbEntry.ImageMimeType = cinema.ImageMimeType;
                    dbEntry.Image = cinema.Image;

                }
            }
            context.SaveChanges();
        }

    }
      
}
