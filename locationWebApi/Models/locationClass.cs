using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace locationWebApi.Models
{
    public class locationClass
    {
        public int location_id { get; set; }
        public string street_address { get; set; }
        public string postal_code { get; set; }
        public string city { get; set; }
        public string state_province { get; set; }
        public string country_id { get; set; }

    }
}