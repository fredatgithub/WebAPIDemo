using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestamiWeb.Models
{
  public class Agence
  {
    /// <summary>
    /// L'id de l'agence
    /// </summary>
    public int idAgence { get; set; }
    /// <summary>
    /// Le nom de l'agence
    /// </summary>
    public string Nom { get; set; }
    /// <summary>
    /// L'adresse de l'agence
    /// </summary>
    public string adresse { get; set; }

  }
}