namespace Domain.Entites.Reservations
{
    using Domain.Entites.Produits;
    using System.Collections.Generic;

    public class Client
    {
        public Client()
        {
            Identite = new HashSet<Identite>();
            ClientTarif = new HashSet<ClientTarif>();
            Reservation = new HashSet<Reservation>();
        }
        public int ClientId { get; set; }
        public int? TypetiersId { get; set; }
        public int? PaysId { get; set; }
        public int? CiviliteId { get; set; }
        public int? BanqueId { get; set; }
        public int? DeviseId { get; set; }
        public int? CategorieId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public string Stat { get; set; }
        public string NIF { get; set; }
        public bool? Taxable { get; set; }
        public string TypeClient { get; set; }
        public string Societe { get; set; }
        public int? CodePostal { get; set; }
        public string Ville { get; set; }
        public string Siren { get; set; }
        public int? NbPer { get; set; }
        public int? GroupeId { get; set; }
        public string Justificatif { get; set; }

        public virtual ICollection<Identite> Identite { get; set; }
        public virtual ICollection<ClientTarif> ClientTarif { get; set; }
        public virtual ICollection<Reservation> Reservation { get; set; }
    }
}
