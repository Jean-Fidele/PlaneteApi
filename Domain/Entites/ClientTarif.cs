namespace Domain.Entites
{
    using System;

    public class ClientTarif
    {
        public int ClientTarifId { get; set; }
        public int ProduitId { get; set; }
        public int ClientId { get; set; }
        public decimal? Tarif { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Client Client { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
