using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;

// .: Info :.
// Cette classe peut être extraite dans une nouvelle page C# mais dans le cadre du TP elle peut être laissé dans la même page
// Il faut éviter le plus possible d’avoir une même page avec plusieurs classes à l'intérieur.
// Même si cela fonctionne, cela peut compliquer la lisibilité du code et, à terme, la maintenance
/// <summary>
/// Objet regroupant les données liés aux avis
/// \nPeut être modifiée
/// </summary>
namespace TPLOCAL1.Models
{    /// 
    public class Avis
    {
        /// <summary>
        /// Nom de famille
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Prénom
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Avis donné (Valeurs possibles : O ou N)
        /// </summary>
        public string AvisDonne { get; set; }
    }
}
