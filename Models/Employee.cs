using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Databases_2_Project2_Grocery_store.Models
{
    public class Employee : Person
    {
        public string Location { get; set; }
        public DateTime HireDate { get; set; }
    }
}
