using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Entities
{
    public class Campus
    {
        public Campus()
        {
            Docenten = new List<Docent>();
        }


        public int CampusId { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Commentaar { get; set; }


        public virtual ICollection<Docent> Docenten { get; set; }
    }
}
