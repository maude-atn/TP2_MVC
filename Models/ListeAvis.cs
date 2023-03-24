using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;


//Ce fichier n'est pas à modifier!!!
namespace TPLOCAL1.Models
{
    public class ListeAvis
    {
        /// <summary>
        /// Fonction permettant de récupérer la liste des avis contenus dans un fichier XML
        /// </summary>
        /// <param name="fichier">chemin du fichier</param>
        public List<Avis> GetAvis(string fichier)
        {
            // On instancie la liste vide
            List<Avis> listeAvis = new List<Avis>();

            // Création d'un objet de type XMLDocument permettant de récupérer les données du fichier physique
            XmlDocument xmlDoc = new XmlDocument();
            // Lecture du fichier à partir d'un objet StreamReader
            StreamReader streamDoc = new StreamReader(fichier);
            string dataXml = streamDoc.ReadToEnd();
            // Chargement des données dans le XmlDocument
            xmlDoc.LoadXml(dataXml);

            // Récupération des noeuds pour les passer en objet Avis puis ajout à la liste 'listeAvis'
            // On boucle sur chaque noeud de type XmlNode ayant pour chemin "root/row" (cf structure du fichier xml)
            // La méthode SelectNodes permet de récupérer tous les noeuds ayant le chemin indiqué
            foreach (XmlNode node in xmlDoc.SelectNodes("root/row"))
            {
                // Récupération des données dans les noeuds fils
                string nom = node["Nom"].InnerText;
                string prenom = node["Prenom"].InnerText;
                string avisdonne = node["Avis"].InnerText;

                // Création de l'objet Avis à ajouter à la liste des résultats
                Avis avis = new Avis
                {
                    Nom = nom,
                    Prenom = prenom,
                    AvisDonne = avisdonne
                };

                // Ajout de l'objet à la liste
                listeAvis.Add(avis);
            }

            // On retourne la liste formée par le traitement à la méthode appelante
            return listeAvis;
        }
    }
}