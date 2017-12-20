using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Tour
    {
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }

        [Required(ErrorMessage = "Tên tour không được trống!")]
        public string Name { get; set; }

        [Required]
        public int TourTypeID { get; set; }

        [ForeignKey("City")]
        public int FromCity { get; set; }

        [ForeignKey("District")]
        public int FromDistrict { get; set; }

        [Required(ErrorMessage = "Số ngày không được trống!")]
        [Range(1, 30, ErrorMessage = "Số ngày phải lớn hơn 0 và nhỏ hơn 30")]
        public int Day { get; set; }

        [Required(ErrorMessage = "Số đêm không được trống!")]
        [Range(1, 30, ErrorMessage = "Số đêm phải lớn hơn 0 và nhỏ hơn 30")]
        public int Night { get; set; }

        public string Status { get; set; }

        [Range(0, 50000000, ErrorMessage = "Giá không được âm!")]
        public int Price { get; set; }

        public string Description { get; set; }

        public virtual TourType TourType { get; set; }
        public virtual City City { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<TourLocation> TourLocations { get; set; }
    }
}
