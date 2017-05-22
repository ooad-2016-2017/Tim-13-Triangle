using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHealth.Models
{

    public class Administrator
    {


        public LinkedList<string> listaOdjela { get; set; }
        public LinkedList<Doktor> listaDoktora { get; set; }
        public LinkedList<Korisnik> listaKorisnika { get; set; }
        public string listaBolnica { get; set; }


        public Administrator(LinkedList<string> listaOdjela, LinkedList<Doktor> listaDoktora, LinkedList<Korisnik> listaKorisnika, LinkedList<string> listaBolnica)
        {

            this.listaOdjela = listaOdjela;
            this.listaDoktora = listaDoktora;
            this.listaKorisnika = listaKorisnika;
            this.listaBolnica = listaBolnica;
            
        }


        public void dodajDoktora(Doktor doktor)
        {
            // dodaj doktora u listu
        }

        public void dodajKorisnika(Korisnik korisnik)
        {
            //dodaj korisnika u listu
        }

        public void dodajBolnicu(string bolnicu)
        {
            // dodaj bolnicu
        }

        public void dodajOdjel(string odjel)
        {
            // dodaj odjel u listu
        }



    }
}
