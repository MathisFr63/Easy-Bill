using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Bill.Models
{
    public interface IDevis
    {
        string DevisId { get; }
        string Objet { get; set; }        
        DateTime Date { get; set; }
        TypeReglement TypeReglement { get; set; }     
        string Note { get; set; }        
        Monnaie Monnaie { get; set; }
        List<IArticle> Articles { get; }
        int Total { get; }

        void ajouterArticle(IArticle article);
        bool supprimerArticle(IArticle article);
    }
}
