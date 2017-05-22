using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{
   public class Korisnik: Osoba
    {

        public string JMBG { get; set; }
        public string brojLicnekarte { get; set; }
        public string brojKnjizice { get; set; }
        public string brojOsiguranika { get; set; }
        public string adresaStanovanja { get; set; }
        public string gradStanovanja { get; set; }


        public string Korisnik (


            string ime, 
            string prezime, 
            string datumRodjenja, 
            Image slikaProfila, 
            string lozinka, 
            string kontaktTelefon, 
            string emailAdresa,
            string JMBG,
            string brojLicneKarte,
            string brojKnjizice, 
            string brojOsiguranika,
            string adresaStanovanja,
            string gradStanovanja): Osoba(ime, prezime, datumRodjenja, slkaProfila, lozinka, kontaktTelefon, emailAdresa)


        {

            this.JMBG = JMBG;
            this.brojLicnekarte = brojLicnekarte;
            this.brojOsiguranika = brojOsiguranika;
            this.adresaStanovanja = adresaStanovanja;
            this.gradStanovanja = gradStanovanja;

        }







    }
}
