namespace Easy_Bill.Models
{
    public class Article
    {
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private Type type;
        public Type Type
        {
            get { return type; }
            set { type = value; }
        }

        private int quantite;
        public int Quantite
        {
            get { return quantite; }
            set { quantite = value; }
        }

        private int prixHT;
        public int PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }

        private int tva;
        public int TVA
        {
            get { return tva; }
            set { tva = value; }
        }

        private int reduction;
        public int Reduction
        {
            get { return reduction; }
            set { reduction = value; }
        }

        public int TotalHT => PrixHT * (1 - Reduction / 100);

        public int Total => TotalHT * (1 + TVA / 100); 
    }
}