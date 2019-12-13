using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestamiWeb.Controllers
{
    public class OIController : ApiController
    {
        // GET: api/GetOI
        public IEnumerable<string> Get()
        {
            return new string[] { "OI numéro 123456789", "Demande de nettoyage de cuve" };
        }

        // GET: api/GetOI/5
        public string Get(int id)
        {
            return $"L'OI numéro {id} est une demande d'intervention d'un nettoyage de cuve";
        }

        // POST: api/GetOI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetOI/5
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
