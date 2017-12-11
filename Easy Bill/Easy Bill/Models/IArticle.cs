using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Bill.Models
{
    public interface IArticle
    {
        string Nom { get; }
        string Description { get; }        
        Type Type { get; }        
        int Quantite { get; }        
        int PrixHT { get; }        
        int TVA { get; }        
        int Reduction { get; }
        int TotalHT { get; }
        int Total { get; }
    }
}
