using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class TourType
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
