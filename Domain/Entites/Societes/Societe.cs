namespace Domain.Entites.Societes
{
    using System.Collections.Generic;

    public class Societe
    {
        public Societe()
        {
            Contacts = new HashSet<Contact>();
        }

        public int SocieteId { get; set; }
        public int PaysId { get; set; }
        public int FormeJuridiqueId { get; set; }
        public int? CategHotelId { get; set; }
        public string Nom { get; set; }
        public decimal? Capital { get; set; }
        public string Adresse { get; set; }
        public string AdressCompl { get; set; }
        public string Region { get; set; }
        public int? RegionCode { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Stat { get; set; }
        public string NIF { get; set; }
        public string Logo { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string ChampLibre { get; set; }
        public string ChampLibre2 { get; set; }
        public string ChampLibre3 { get; set; }
        public virtual CategHotel CategHotel { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual FormeJuridique FormeJuridique { get; set; }
        public virtual Pays Pays { get; set; }
    }
}
