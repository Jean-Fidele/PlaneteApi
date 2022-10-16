namespace Domain.Entites.Reservations
{
    using System;

    public class Identite
    {
        public int IdentiteId { get; set; }
        public int CliendId { get; set; }
        public string Code { get; set; }
        public string Libelle { get; set; }
        public string Numero { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string DeliveryPlace { get; set; }
        public virtual Client Client { get; set; }
    }
}
