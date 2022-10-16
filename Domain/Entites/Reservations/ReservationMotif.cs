namespace Domain.Entites.Reservations
{
    public class ReservationMotif
    {
        public int ReservationMotifId { get; set; }
        public string Code { get; set; }
        public string Motif { get; set; }
        public bool? TypeModif { get; set; }
    }
}
