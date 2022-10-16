namespace Domain.Entites.Devises
{
    public class TenuCptDevise
    {
        public int TenuCptDeviseId { get; set; }
        public int DeviseId { get; set; }
        public int? HOTEL { get; set; }
        public int? RESTO { get; set; }
        public int? LOGISTIC { get; set; }
        public virtual Devise Devise { get; set; }
    }
}
