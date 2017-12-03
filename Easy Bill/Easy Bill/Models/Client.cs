using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Easy_Bill.Models
{
    public class Client : Entité
    {
        public Client(string nom, string siteWeb, Personne personne, Lieu lieu) : base(nom, siteWeb, personne, lieu)
        {
        }
    }
}