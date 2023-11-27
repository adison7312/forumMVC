using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class City
    {
        public int CityID { get; set; }

        public string Name { get; set; }

        public int CountryID { get; set; }

        public virtual Country Country { get; set; }
    }
}