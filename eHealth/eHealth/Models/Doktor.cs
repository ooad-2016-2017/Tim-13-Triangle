using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
    public class Doktor
    {

        public string odjel { get; set; }
        public List<DateTime> slobodniTermini { get; set; }
        public string nazivBolnice { get; set; }

        public Doktor(string odjel, List<DateTime> slobodniTermini, string nazivBolnice)
        {

            this.odjel = odjel;
            this.slobodniTermini = slobodniTermini;
            this.nazivBolnice = nazivBolnice;

        }



    }
}
