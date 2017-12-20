using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Group
    {
        public int ID { get; set; }

        public string Code { get; set; }

        [Required]
        public int TourID { get; set; }

        [Required(ErrorMessage = "Tên đoàn không được trống!")]
        public string Name { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [Required]
        public string PickupLocation { get; set; }

        [Required]
        public string DropLocation { get; set; }

        public string Description { get; set; }

        public string Policy { get; set; }

        public virtual ICollection<GroupFee> GroupDetails { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
