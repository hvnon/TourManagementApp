using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class District
    {
        public int ID { get; set; }

        public int CityID { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual City City { get; set; }
    }
}
