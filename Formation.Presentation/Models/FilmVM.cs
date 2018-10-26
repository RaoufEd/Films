using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Formation.Presentation.Models
{
    public class FilmVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OutDate { get; set; }
        public string ImageURL { get; set; }
        public string Genre { get; set; }
    }
}