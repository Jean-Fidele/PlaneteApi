namespace Domain.Entites.Objets
{
    public class Utilise
    {
        public int UtiliseId { get; set; }
        public int? OutillageId { get; set; }
        public int? DomaineId { get; set; }
        public virtual Domaine Domaine { get; set; }
        public virtual Outillage Outillage { get; set; }
    }
}
