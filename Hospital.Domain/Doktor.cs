using System;
using System.Collections;
using System.Collections.Generic;

namespace Hospital.Domain
{
    public class Doktor
    {
        public Doktor()
        {
            Rasporedi = new HashSet<Raspored>();
            TipoviPregleda = new HashSet<TipPregleda>();
        }
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Jmbg { get; set; }
        public string Specijalnost { get; set; }
        public virtual ICollection<Raspored> Rasporedi { get; set; }
        public virtual ICollection<TipPregleda> TipoviPregleda { get; set; }
    }
}
