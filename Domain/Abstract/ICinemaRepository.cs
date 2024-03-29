﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstract
{
    public interface ICinemaRepository
    {
        IEnumerable<Cinema> Cinemas { get; }
        void SaveCinema(Cinema cinema);
        Cinema DeleteCinema(int CinemaId);
    }    


}
