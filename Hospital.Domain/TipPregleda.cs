using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain
{
   public class TipPregleda
    {
        public TipPregleda()
        {
            Zakazivanja = new HashSet<ZakazivanjePregleda>();
            Doktori = new HashSet<Doktor>();
        }
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Napomena { get; set; }
        public virtual ICollection<ZakazivanjePregleda> Zakazivanja { get; set; }
        public virtual ICollection<Doktor> Doktori { get; set; }

    }
}
