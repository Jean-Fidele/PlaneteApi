namespace Domain.Entites.Produits
{
    using Domain.Entites.Devises;
    using System;

    public class ProdCatTarifaire
    {
        public int ProdCatTarifaireId { get; set; }
        public int ProduitId { get; set; }
        public int? DeviseId { get; set; }
        public int? CategTarifaireId { get; set; }
        public decimal? Tarif { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual CategTarifaire CategTarifaire { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
