namespace Easy_Bill.Models
{
    public class Personne
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        private Civilite civilite;
        public Civilite Civilite
        {
            get { return civilite; }
            set { civilite = value; }
        }

        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        private string portable;
        public string Portable
        {
            get { return portable; }
            set { portable = value; }
        }

        private string fax;
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        private string commentaire;

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public Personne(string nom, string prenom, Civilite civilite, string mail, string telephone, string portable, string fax, string commentaire)
        {
            Nom = nom;
            Prenom = prenom;
            Civilite = civilite;
            Telephone = telephone;
            Portable = portable;
            Fax = fax;
            Commentaire = commentaire;
        }
    }
}