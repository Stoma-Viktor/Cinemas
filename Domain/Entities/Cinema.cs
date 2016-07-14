using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   public class Cinema
    {
       public int CinemaId { get; set; }
       public string CinemaName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public string Directors { get; set; }
        public string Artors { get; set; }
        public int time { get; set; }

    }
}
