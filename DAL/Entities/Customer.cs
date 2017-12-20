using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Mã khách hàng không được trống!")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Họ không được trống!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Tên không được trống!")]
        public string FirstName { get; set; }

        [Required]
        public string IdentityNumber { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool Gender { get; set; }

    }
}
