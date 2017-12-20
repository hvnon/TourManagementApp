using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Location
    {
        public int ID { get; set; }

        [Required]
        public int CityID { get; set; }

        [Required]
        public int DistrictID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual City City { get; set; }
        public virtual District District { get; set; }
    }
}
