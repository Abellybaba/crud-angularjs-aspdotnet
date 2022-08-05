using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using locationWebApi.Models;



namespace locationWebApi.Controllers
{
    public class locationRecordController : ApiController

    {
        newDBEntities nDbObj = new newDBEntities();

        public IHttpActionResult getLocationRec()
        {
           
            IList<locationClass> locObj = nDbObj.locations.Include("locations")
                .Select(x => new locationClass()
                {
                    location_id = x.location_id,
                    street_address = x.street_address,
                    postal_code = x.postal_code,
                    city = x.city,
                    state_province = x.state_province,
                    country_id = x.country_id

                }).ToList<locationClass>();

            return Ok(locObj);
        }

        public IHttpActionResult insertLocationRec(location loc)
        {
            nDbObj.locations.Add(loc);
            nDbObj.SaveChanges();
            return Ok("The Record was inserted Successfully!");
        }

    }
}
