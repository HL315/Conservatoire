using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConservatoireChatgpt.Modele
{
    public class Transaction
    {
        public int ProfesseurID { get; set; }
        public int EleveID { get; set; }
        public DateTime Date { get; set; }
        public decimal Somme { get; set; }
        public string Libelle { get; set; }
    }

}
