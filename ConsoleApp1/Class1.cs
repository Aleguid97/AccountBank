using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contocorrente
{
    internal class Conto
    {
        public string CCesiste { get; set; }
        public int Prelievo { get; set; }
        public int Versamento { get; set; }
        public int Patrimonio { get; set; }

        public string CheckAccess()
        {
            if (CCesiste == "yes")
            {
                return "Benvenuto sig. Guida";
            }


            else
            {
                return "Non possiede nessun conto in questa banca";
            }
        }
    }

        
