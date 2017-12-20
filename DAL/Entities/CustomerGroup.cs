using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class CustomerGroup
    {
        public int ID { get; set; }

        public int CustomerID { get; set; }

        public int GroupID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Group Group { get; set; }
    }
}
