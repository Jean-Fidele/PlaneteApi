namespace Domain.Entites.Devises
{
    using System;

    public class CotationDevise
    {
        public int CotationDeviseId { get; set; }
        public int DeviseId { get; set; }
        public int DeviseIdRep { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal MID { get; set; }
        public decimal? REPORTING { get; set; }
        public decimal? ETABLISSEMENT { get; set; }
        public decimal? VENTE { get; set; }
        public decimal? ACHAT { get; set; }
        public virtual Devise Devise { get; set; }
    }
}
