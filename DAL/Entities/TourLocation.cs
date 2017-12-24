using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class TourLocation
    {
        [Key, Column(Order = 0)]
        public int TourID { get; set; }

        [Key, Column(Order = 1)]
        public int LocationID { get; set; }

        public int Order { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual Location Location { get; set; }

    }
}
