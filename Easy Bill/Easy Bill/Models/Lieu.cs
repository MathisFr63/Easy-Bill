namespace Easy_Bill.Models
{
    public class Lieu
    {
        private string adresse;
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        private int? complement;
        public int? Complement
        {
            get { return complement; }
            set { complement = value; }
        }

        private int cp;
        public int CP
        {
            get { return cp; }
            set { cp = value; }
        }

        private string ville;
        public string Ville
        {
            get { return ville; }
            set { ville = value; }
        }

        private string pays;

        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        public Lieu(string adresse, int cp, string ville, string pays, int? complement)
        {
            Adresse = adresse;
            CP = cp;
            Ville = ville;
            Pays = pays;
            Complement = complement;
        }
    }
}