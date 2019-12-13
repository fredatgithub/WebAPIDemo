using GestamiWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GestamiWeb.Controllers
{
  /// <summary>
  /// API Agence
  /// </summary>
  public class AgenceController : ApiController
  {
    // récupérer depuis BDD
    List<Agence> agences = new List<Agence>();
    public AgenceController()
    {
      agences.Add(new Agence { idAgence = 1, Nom = "Suez Lyon", adresse = "1 main street" });
      agences.Add(new Agence { idAgence = 2, Nom = "Suez Neuilly", adresse = "2 main street" });
      agences.Add(new Agence { idAgence = 3, Nom = "Suez Marseille", adresse = "1 reu de la canebière" });

    }

    /// <summary>
    /// Obtenir le nom d'une agence par son ID
    /// </summary>
    /// <param name="idAgence">L'id de l'agence</param>
    /// <returns>Le nom de l'agence</returns>
    [Route("api/Agence/GetAgenceNameById/{idAgence:int}")]
    [HttpGet]
    public string GetAgenceById(int idAgence)
    {
      // get it from BDD
      string result = string.Empty;
      foreach (var agence in agences)
      {
        if (agence.idAgence == idAgence)
        {
          result = agence.Nom;
          break;
        }
      }
      return result;
    }

    // GET: api/Agence
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET: api/Agence/5
    public string Get(int id)
    {
      return $"L'agence {id} a pour adresse 1 rue des papillons";
    }

    // POST: api/Agence
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Agence/5
    public void Put(int id, [FromBody]string value)
    {
    }
  }
}
