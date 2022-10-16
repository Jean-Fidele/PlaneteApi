namespace Domain.Entites.Objets
{
    using System;

    public class Maintenance
    {
        public int MaintenanceId { get; set; }
        public int? ObjetId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public virtual Objet Objet { get; set; }
    }
}
