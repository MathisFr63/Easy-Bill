using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easy_Bill.Models
{
    public class Entité
    {
        private String nom;
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private String siteWeb;
        public String SiteWeb
        {
            get { return siteWeb; }
            set { siteWeb = value; }
        }

        public Personne Personne { get; private set; }

        public Lieu Adresse { get; private set; }

        // Liste des devis liés à l'entreprise
        public List<IDevis> Devis { get; private set; }


        public Entité(string nom, string siteWeb, Personne personne, Lieu lieu)
        {
            Nom = nom;
            SiteWeb = siteWeb;
            Personne = personne;
            Adresse = lieu;
        }
    }
}