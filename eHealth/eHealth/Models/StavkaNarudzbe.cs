using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
    
    public class StavkaNarudzbe
    {
        public double kolicina { get; set; }
        public double cijena { get; set; }


        public StavkaNarudzbe(double kolicina, double cijena)
        {
            this.kolicina = kolicina;
            this.cijena = cijena;
        }


    }
}
