﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation.Domain.Entity
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime OutDate { get; set; }
        public string ImageURL { get; set; }
        public string Genre { get; set; }
        public int? ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public virtual Producer Producer { get; set; }
    }
}
