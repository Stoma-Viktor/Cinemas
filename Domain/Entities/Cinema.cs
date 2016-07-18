using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Domain.Entities
{
   public class Cinema
    {
       [HiddenInput(DisplayValue = false)]
       [Display(Name = "Id")]
       public int CinemaId { get; set; }
       [Required(ErrorMessage = "Пожалуйста, введите название фильма")]
       [Display(Name = "Название")]
       public string CinemaName { get; set; }

       [DataType(DataType.MultilineText)]
       [Required(ErrorMessage = "Пожалуйста, введите описание фильма")]
       [Display(Name = "Описание")]
       public string Description { get; set; }
       [Display(Name = "Жанр")]
       [Required(ErrorMessage = "Пожалуйста, введите жанр фильма")]
        public string Category { get; set; }
       [Display(Name = "Цена(руб)")]
       [Required]
       [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите корректную цену фильма")]
        public decimal Price { get; set; }
       [Display(Name = "Год")]
       [Required]
       [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите корректный год выпуска фильма")]
        public int Year { get; set; }
       [Required(ErrorMessage = "Пожалуйста, введите страну выпуска фильма")]
       [Display(Name = "Страна")]
        public string Country { get; set; }
       [Required(ErrorMessage = "Пожалуйста, введите режисёра фильма")]
       [Display(Name = "Режисёр")]
        public string Directors { get; set; }
       [Required(ErrorMessage = "Пожалуйста, введите актёров фильма")]
       [Display(Name = "Актёры")]
        public string Artors { get; set; }
       [Required]
       [Range(0.01, double.MaxValue, ErrorMessage = "Пожалуйста, введите корректную продолжительность фильма")]
       [Display(Name = "Время")]
        public int time { get; set; }

       [Required(ErrorMessage = "Пожалуйста, введите путь к изображению")]
       [Display(Name = "Постер(пока путь к файлу)")]
       public string Image { get; set; }

       public byte[] ImageData { get; set; }
       public string ImageMimeType { get; set; }

    }
}
