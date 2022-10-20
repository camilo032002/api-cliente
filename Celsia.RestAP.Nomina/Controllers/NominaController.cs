using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Celsia.RestAP.Nomina.Controllers
{
    public class NominaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Echoping()
        {
            return Ok(true);
        }
    }
}