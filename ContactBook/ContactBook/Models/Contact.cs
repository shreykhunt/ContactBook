using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactBook.Models
{
    public class Contact
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Phone]
            public string PhoneNumber { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            public string Address { get; set; }

    }
}