namespace Domain.Entites.Societes.Config
{
    public class MailContenu
    {
        public int MailContenuId { get; set; }
        public string Intitule { get; set; }
        public string Operation { get; set; }
        public string Entet { get; set; }
        public string Introduction { get; set; }
        public bool? NumeroReservation { get; set; }
        public bool? StartDate { get; set; }
        public bool? EndDate { get; set; }
        public bool? CreateOn { get; set; }
        public bool? ModifyOn { get; set; }
        public bool? PayementMode { get; set; }
        public bool? ProduitCode { get; set; }
        public bool? ProduitNom { get; set; }
        public bool? Quantite { get; set; }
        public bool? UnitaireTarif { get; set; }
        public bool? TotalTarif { get; set; }
        public bool? TtcTarif { get; set; }
        public string Remerciement { get; set; }
    }
}
