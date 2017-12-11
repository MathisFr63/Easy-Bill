using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Easy_Bill.Models
{
    public class Devis
    {
        public string DevisId { get; private set; }

        private string objet;
        public string Objet
        {
            get { return objet; }
            set { objet = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private TypeReglement typeReglement;
        public TypeReglement TypeReglement
        {
            get { return typeReglement; }
            set { typeReglement = value; }
        }

        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        private Monnaie monnaie;
        public Monnaie Monnaie
        {
            get { return monnaie; }
            set { monnaie = value; }
        }

        public List<IArticle> Articles { get; private set; }

        public int Total => Articles.Sum(a => a.Total);

        public Devis(string sujet, DateTime date, string commentaire, TypeReglement type, Monnaie typeMonnaie)
        {
            Random rand = new Random();
            Objet = sujet;
            Date = date;
            TypeReglement = type;
            Note = commentaire;
            Monnaie = typeMonnaie;

            Articles = new List<IArticle>();
            DevisId = "D" + date.ToShortDateString() + rand.Next(1000, 9999);
        }

        public void ajouterArticle(IArticle article)
        {
            Articles.Add(article);
        }
        public bool supprimerArticle(IArticle article)
        {
            return Articles.Remove(article);
        }
    }
}