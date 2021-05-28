using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Databases_2_Project2_Grocery_store.Models
{
    public class Person : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [NotMapped]
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
