using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
   public class Lijek
    {

        public string naziv { get; set; }
        public string opis { get; set; }
        public double cijena { get; set; }



        public Lijek(string naziv, string opis, double cijena)
        {
            this.naziv = naziv;
            this.opis = opis;
            this.cijena = cijena;

        }



    }
}
