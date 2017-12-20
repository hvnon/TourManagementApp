using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Role
    {
        public int ID { get; set; }

        public int EmployeeID { get; set; }

        public int GroupID { get; set; }

        public string RoleName { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Group Group { get; set; }
    }
}
