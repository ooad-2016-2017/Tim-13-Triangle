using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
   public class Pregled
    {

        public DateTime pregled { get; set; }
        public Doktor doktor { get; set; }


        public Pregled (DateTime pregled, Doktor doktor)
        {
            this.pregled = pregled;
            this.doktor = doktor;
        }



    }
}
