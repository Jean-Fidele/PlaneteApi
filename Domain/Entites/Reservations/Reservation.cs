namespace Domain.Entites.Reservations
{
    using Domain.Entites.Produits;
    using System;

    public class Reservation
    {
        public int ReservationId { get; set; }
        public int? ProduitId { get; set; }
        public int? ClientId { get; set; }
        public int? StatusId { get; set; }
        public int? ModepayementId { get; set; }
        public string NumRes { get; set; }
        public int? ProId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? ReservationDate { get; set; }
        public int? Quantite { get; set; }
        public int? NombrePax { get; set; }
        public string Commentaire { get; set; }
        public int? Etat { get; set; }
        public int? ObjetId { get; set; }
        public virtual Client Client { get; set; }
        public virtual PaiementMode PaiementMode { get; set; }
        public virtual Produit Produit { get; set; }
        public virtual Statut Statut { get; set; }
    }
}
