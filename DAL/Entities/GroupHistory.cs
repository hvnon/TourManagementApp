using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class GroupHistory
    {
        public int ID { get; set; }

        public int GroupID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy H:mm}")]
        public DateTime Date { get; set; }

        public virtual Group Group { get; set; }
    }
}
