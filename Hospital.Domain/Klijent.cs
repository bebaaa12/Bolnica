using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain
{
   public class Klijent
    {
        public Klijent()
        {
            Zakazivanja = new HashSet<ZakazivanjePregleda>();
        }
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Jmbg { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public virtual ICollection<ZakazivanjePregleda> Zakazivanja { get; set; }
    }
}
