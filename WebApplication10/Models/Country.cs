using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Country
    {
        public int CountryID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}