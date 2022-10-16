namespace Domain.Entites
{
    using System;

    public class PromoTarif
    {
        public int PromoTarifId { get; set; }
        public int ProduitId { get; set; }
        public int DeviseId { get; set; }
        public decimal? Tarif { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Devise Devise { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
