namespace Domain.Entites.Produits
{
    using Domain.Entites.Devises;
    using System;

    public class ProduitTarif
    {
        public int ProduitTarifId { get; set; }
        public int ProduitId { get; set; }
        public int DeviseId { get; set; }
        public decimal? Tarif { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Somme { get; set; }
        public bool? Taxable { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
