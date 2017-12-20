using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class GroupFee
    {
        public int ID { get; set; }

        public int GroupID { get; set; }
        
        public int FeeTypeID { get; set; }

        public string Description { get; set; }

        [Range(0, 50000000, ErrorMessage = "Giá không được âm!")]
        public int Price { get; set; }

        public virtual Group Group { get; set; }
        public virtual FeeType FeeType { get; set; }
    }
}
