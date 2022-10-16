using Domain.Entites.Devises;

namespace Domain.Entites.Reservations
{
    public class Fournisseur
    {
        public int FournisseurId { get; set; }
        public int? DeviseId { get; set; }
        public int? PaiementModeId { get; set; }
        public string Code { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string PeriodeDePaiement { get; set; }
        public string DelaiLivraison { get; set; }
        public decimal? FraisLivraison { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual PaiementMode PaiementMode { get; set; }
    }
}
